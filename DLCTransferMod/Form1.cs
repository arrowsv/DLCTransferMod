using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using Gibbed.IO;
using System.Collections;
using System.Diagnostics;
using System.Threading;

namespace DLCTransferMod
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            gamePath.Select();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.Title = "Select your RF:GR game folder!";
            dialog.InitialDirectory = "C:\\";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (File.Exists(dialog.FileName + "\\rfg.exe"))
                {
                    gamePath.Text = dialog.FileName;
                    MessageBox.Show("The game path has been set, you may now install the mod!");
                    browseButton.Enabled = false;

                    //---------------------------------------------------------//

                    if (string.IsNullOrEmpty(gamePath.Text))
                    {
                        installButton.Enabled = false;
                        return;
                    }
                    else
                    {
                        installButton.Enabled = true;
                    }

                    //---------------------------------------------------------//
                }
                else
                {
                    MessageBox.Show("The game path you have selected does not include rfg.exe!");
                }
            }
        }

        public void UnpackVPP()
        {
            string tempFolder = gamePath.Text + "\\data\\_TEMP";

            DirectoryInfo di = Directory.CreateDirectory(tempFolder);

            try
            {
                // Unpack misc.vpp_pc
                string[] Args = { gamePath.Text + "\\data\\misc.vpp_pc", gamePath.Text + "\\data\\_TEMP\\misc.vpp_pc.UNPACKED\\" };
                int UnpackExitCode = new Gibbed.Volition.Pack.VPP.Unpacker<Gibbed.Volition.FileFormats.PackageFileV3>().Main(Args);
                

                // If the DLC Vehicles checkbox is checked, unpack vehicles_r.vpp_pc
                if (installVehicles.Checked == true)
                {
                        string[] Args3 = { gamePath.Text + "\\data\\vehicles_r.vpp_pc", gamePath.Text + "\\data\\_TEMP\\vehicles_r.vpp_pc.UNPACKED\\" };
                        int UnpackExitCode3 = new Gibbed.Volition.Pack.VPP.Unpacker<Gibbed.Volition.FileFormats.PackageFileV3>().Main(Args3);
                }
                else
                {
                    Console.WriteLine("Vehicles aren't being unpacked.");
                }

                unpackProgress.Value = 60;

                // If the DLC Weapons checkbox is checked, unpack items.vpp_pc
                if (installWeapons.Checked == true)
                {
                        string[] Args2 = { gamePath.Text + "\\data\\items.vpp_pc", gamePath.Text + "\\data\\_TEMP\\items.vpp_pc.UNPACKED\\" };
                        int UnpackExitCode2 = new Gibbed.Volition.Pack.VPP.Unpacker<Gibbed.Volition.FileFormats.PackageFileV3>().Main(Args2);
                }
                else
                {
                    Console.WriteLine("Weapons aren't being unpacked.");
                }

                unpackProgress.Value = 100;

                unpackingGIF.Image = DLCTransferMod.Properties.Resources.icons8_checkmark_15;
            }
            catch (Exception e)
            {
                MessageBox.Show("Process failed to run: " + e);
            }
        }

        public void PackVPP()
        {
            try
            {
               string[] Args = { gamePath.Text + "\\data\\misc.vpp_pc", gamePath.Text + "\\data\\_TEMP\\misc.vpp_pc.UNPACKED\\" };
               int UnpackExitCode = new Gibbed.Volition.Pack.VPP.Packer<Gibbed.Volition.FileFormats.PackageFileV3, Gibbed.Volition.FileFormats.Package.Entry>().Main(Args);

                packingProgress.Value = 10;

                if (installWeapons.Checked == true)
                {
                    string[] Args2 = { gamePath.Text + "\\data\\items.vpp_pc", gamePath.Text + "\\data\\_TEMP\\items.vpp_pc.UNPACKED\\" };
                    int UnpackExitCode2 = new Gibbed.Volition.Pack.VPP.Packer<Gibbed.Volition.FileFormats.PackageFileV3, Gibbed.Volition.FileFormats.Package.Entry>().Main(Args2);
                }
                else
                {
                    Console.WriteLine("");
                }

                packingProgress.Value = 55;

                if (installVehicles.Checked == true)
                {
                    string[] Args3 = { gamePath.Text + "\\data\\vehicles_r.vpp_pc", gamePath.Text + "\\data\\_TEMP\\vehicles_r.vpp_pc.UNPACKED\\" };
                    int UnpackExitCode3 = new Gibbed.Volition.Pack.VPP.Packer<Gibbed.Volition.FileFormats.PackageFileV3, Gibbed.Volition.FileFormats.Package.Entry>().Main(Args3);
                }
                else
                {
                    Console.WriteLine("t");
                }

                packingProgress.Value = 100;

                packingGIF.Image = DLCTransferMod.Properties.Resources.icons8_checkmark_15;
            }
            catch (Exception e)
            {
                MessageBox.Show("Process failed to run: " + e);
            }
        }

        private void installButton_Click(object sender, EventArgs e)
        {

            // Check if any checkbox was checked before continuing
            if (installVehicles.Checked == false & installWeapons.Checked == false)
            {
                MessageBox.Show("You haven't checked anything to install!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Console.WriteLine("The mod is now starting the installation process.");
            }

            // Change tab to install
            materialTabControl1.SelectedIndex = 2;

            // Weapons
            var sourceDirectoryWEAPONMISC = new DirectoryInfo(Environment.CurrentDirectory + "\\items.vpp\\misc.vpp");
            var sourceDirectoryWEAPONITEMS = new DirectoryInfo(Environment.CurrentDirectory + "\\items.vpp\\items.vpp");

            var targetDirectoryWEAPONMISC = new DirectoryInfo(gamePath.Text + "\\data\\_TEMP\\misc.vpp_pc.UNPACKED\\");
            var targetDirectoryWEAPONITEMS = new DirectoryInfo(gamePath.Text + "\\data\\_TEMP\\items.vpp_pc.UNPACKED\\");

            //Vehicles
            var sourceDirectoryVEHICLEMISC = new DirectoryInfo(Environment.CurrentDirectory + "\\vehicles_r.vpp\\misc.vpp");
            var sourceDirectoryVEHICLE_R = new DirectoryInfo(Environment.CurrentDirectory + "\\vehicles_r.vpp\\vehicles_r.vpp");

            var targetDirectoryVEHICLEMISC = new DirectoryInfo(gamePath.Text + "\\data\\_TEMP\\misc.vpp_pc.UNPACKED\\");
            var targetDirectoryVEHICLE_R = new DirectoryInfo(gamePath.Text + "\\data\\_TEMP\\items.vpp_pc.UNPACKED\\");

            try
            {
                UnpackVPP();

                copyingGIF.Visible = true;

                // Copy files to vehicles_r.vpp & misc.vpp if checked
                if (installVehicles.Checked == true)
                {
                    CopyVehiclesMisc(sourceDirectoryVEHICLEMISC, targetDirectoryVEHICLEMISC);
                    CopyVehicles_r(sourceDirectoryVEHICLE_R, targetDirectoryVEHICLE_R);

                }
                else
                {
                    Console.WriteLine("Vehicles aren't being installed.");
                }

                copyProgress.Value = 25;

                // Copy files to items.vpp_pc & misc.vpp if checked
                if (installWeapons.Checked == true)
                {
                    CopyWeaponsMisc(@sourceDirectoryWEAPONMISC, @targetDirectoryWEAPONMISC);
                    CopyWeaponsItems(@sourceDirectoryWEAPONITEMS, @targetDirectoryWEAPONITEMS);
                }
                else
                {
                    Console.WriteLine("Vehicles aren't being installed.");
                }

                copyProgress.Value = 65;

                copyingGIF.Image = DLCTransferMod.Properties.Resources.icons8_checkmark_15;

                // Delete vpp files so it can pack
                File.Delete(gamePath.Text + "\\data\\misc.vpp_pc");

                if (installWeapons.Checked == true)
                {
                    File.Delete(gamePath.Text + "\\data\\items.vpp_pc");
                }
                else
                {
                    Console.WriteLine("items.vpp isn't being deleted.");
                }

                if (installVehicles.Checked == true)
                {
                    File.Delete(gamePath.Text + "\\data\\vehicles_r.vpp_pc");
                }
                else
                {
                    Console.WriteLine("vehicles_r.vpp isn't being deleted.");
                }



                // Pack VPPs
                packingGIF.Visible = true;

               PackVPP();

                packingGIF.Image = DLCTransferMod.Properties.Resources.icons8_checkmark_15;


                // Cleaning files
                cleaningGIF.Visible = true;

                if (Directory.Exists(gamePath.Text + "\\data\\_TEMP\\"))
                {
                    try
                    {
                        Directory.Delete(gamePath.Text + "\\data\\_TEMP\\", recursive: true);
                    }
                    catch
                    {
                        Thread.Sleep(2000);
                        Directory.Delete(gamePath.Text + "\\data\\_TEMP\\", recursive: true);
                    }
                }

                cleanProgress.Value = 100;

                packingGIF.Image = DLCTransferMod.Properties.Resources.icons8_checkmark_15;

                wait(3000);

                materialTabControl1.SelectedIndex = 3;

            }
            catch (Exception a)
            {
                MessageBox.Show("Process failed to run: " + a.ToString());
            }
        }

        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            //Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                //Console.WriteLine("stop wait timer");
            };
            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void revertButton_Click(object sender, EventArgs e)
        {
            //RevertVPPs();

            //Directory.Delete(gamePath.Text + "\\data\\_DLCMODTOOL_BACKUPS\\", true);

            //StreamWriter strm = File.CreateText(Environment.CurrentDirectory + "\\DO_NOT_EDIT\\installed.txt");
            //strm.Flush();
            //strm.Close();

            //using (StreamWriter file = new StreamWriter(Environment.CurrentDirectory + "\\DO_NOT_EDIT\\installed.txt", true))
            //{
            //    file.WriteLine("false");
            //}
        }

        private string cleanPath(string toCleanPath, string replaceWith = "-")
        {
            //get just the filename - can't use Path.GetFileName since the path might be bad!  
            string[] pathParts = toCleanPath.Split(new char[] { '\\' });
            string newFileName = pathParts[pathParts.Length - 1];
            //get just the path  
            string newPath = toCleanPath.Substring(0, toCleanPath.Length - newFileName.Length);
            //clean bad path chars  
            foreach (char badChar in Path.GetInvalidPathChars())
            {
                newPath = newPath.Replace(badChar.ToString(), replaceWith);
            }
            //clean bad filename chars  
            foreach (char badChar in Path.GetInvalidFileNameChars())
            {
                newFileName = newFileName.Replace(badChar.ToString(), replaceWith);
            }
            //remove duplicate "replaceWith" characters. ie: change "test-----file.txt" to "test-file.txt"  
            if (string.IsNullOrWhiteSpace(replaceWith) == false)
            {
                newPath = newPath.Replace(replaceWith.ToString() + replaceWith.ToString(), replaceWith.ToString());
                newFileName = newFileName.Replace(replaceWith.ToString() + replaceWith.ToString(), replaceWith.ToString());
            }
            //return new, clean path:  
            return newPath + newFileName;
        }

        //public void RevertVPPs()
        //{
        //    string gameReplacement = gamePath.Text.Replace(@"\", @"\\").ToString();

        //    string gamePath2 = gameReplacement + "\\data\\";

        //    string backupFolder = gameReplacement + "\\data\\_DLCMODTOOL_BACKUPS\\";

        //    string miscFile = gameReplacement + "misc.vpp_pc";

        //    string fileToCopy = backupFolder + "misc.vpp_pc";
        //    string fileToCopy2 = backupFolder + "items.vpp_pc";
        //    string fileToCopy3 = backupFolder + "vehicles_r.vpp_pc";
        //    string destinationDirectory = gamePath2;

        //    Console.WriteLine(gameReplacement);
        //    Console.WriteLine(backupFolder);
        //    Console.WriteLine(fileToCopy);
        //    Console.WriteLine(destinationDirectory);
        //    Console.WriteLine(fileToCopy2);

        //    //File.Delete(@miscFile);
        //    //File.Delete(gamePath.Text + "\\data\\items.vpp_pc");
        //    //File.Delete(gamePath.Text + "\\data\\vehicles_r.vpp_pc");

        //    //File.Copy(fileToCopy, destinationDirectory + Path.GetFileName(fileToCopy));
        //    //File.Copy(fileToCopy2, destinationDirectory + Path.GetFileName(fileToCopy2));
        //    //File.Copy(fileToCopy3, destinationDirectory + Path.GetFileName(fileToCopy3));
        //}

        private void gamePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 1;
        }


        // ---------------------------------------------------------------------------------- //

        private void CopyVehiclesMisc(DirectoryInfo source, DirectoryInfo target)
        {
            string path = gamePath.Text + "\\data\\_TEMP\\misc.vpp_pc.UNPACKED\\";
            string[] files = Directory.GetFiles(Environment.CurrentDirectory + "\\vehicles_r.vpp\\misc.vpp");
            try
            {
                foreach (string file in files)
                {
                    // Delete files with names from program folder
                    string filenames = Path.GetFileName(file);
                    Console.WriteLine(filenames);
                    File.Delete(Path.Combine(path, filenames));
                }
            }
            catch (Exception a)
            {

            }

            foreach (DirectoryInfo dir in source.GetDirectories())
                CopyVehiclesMisc(dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in source.GetFiles("*.*", SearchOption.AllDirectories))
                file.CopyTo(Path.Combine(target.FullName, file.Name));
        }

        private void CopyVehicles_r(DirectoryInfo source, DirectoryInfo target)
        {
            string path = gamePath.Text + "\\data\\_TEMP\\vehicles_r.vpp_pc.UNPACKED\\";
            string[] files = Directory.GetFiles(Environment.CurrentDirectory + "\\vehicles_r.vpp\\vehicles_r.vpp");
            try
            {
                foreach (string file in files)
                {
                    // Delete files with names from program folder
                    string filenames = Path.GetFileName(file);
                    Console.WriteLine(filenames);
                    File.Delete(Path.Combine(path, filenames));
                }
            }
            catch (Exception a)
            {

            }

            foreach (DirectoryInfo dir in source.GetDirectories())
                CopyVehicles_r(dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in source.GetFiles("*.*", SearchOption.AllDirectories))
                file.CopyTo(Path.Combine(target.FullName, file.Name));
        }




        // --------- WEAPONS ---------

        private void CopyWeaponsMisc(DirectoryInfo source, DirectoryInfo target)
        {
            string path = gamePath.Text + "\\data\\_TEMP\\misc.vpp_pc.UNPACKED\\";
            string[] files = Directory.GetFiles(Environment.CurrentDirectory + "\\items.vpp\\misc.vpp");
            try
            {
                foreach (string file in files)
                {
                    // Delete files with names from program folder
                    string filenames = Path.GetFileName(file);
                    Console.WriteLine(filenames);
                    File.Delete(Path.Combine(path, filenames));
                }
            }
            catch (Exception a)
            {

            }

            foreach (DirectoryInfo dir in source.GetDirectories())
                CopyWeaponsMisc(dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in source.GetFiles("*.*", SearchOption.AllDirectories))
                file.CopyTo(Path.Combine(target.FullName, file.Name));
        }

        private void CopyWeaponsItems(DirectoryInfo source, DirectoryInfo target)
        {
            string path = gamePath.Text + "\\data\\_TEMP\\items.vpp_pc.UNPACKED\\";
            string[] files = Directory.GetFiles(Environment.CurrentDirectory + "\\items.vpp\\items.vpp");
            try
            {
                foreach (string file in files)
                {
                    // Delete files with names from program folder
                    string filenames = Path.GetFileName(file);
                    Console.WriteLine(filenames);
                    File.Delete(Path.Combine(path, filenames));
                }
            }
            catch (Exception a)
            {

            }

            foreach (DirectoryInfo dir in source.GetDirectories())
                CopyWeaponsItems(dir, target.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in source.GetFiles("*.*", SearchOption.AllDirectories))
                file.CopyTo(Path.Combine(target.FullName, file.Name));
        }
    }
}
