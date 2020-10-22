using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* von Maik Hoffmann
###################################################################################################
#
#                     MODUL "StartApp"
#
#                    (c) Maik Hoffmann
#                    maikhoffmann@outlook.com
#
#  Funktionen zum starten von Tools vom USB Laufwerk
# 
#  Code für die Batch:
#  subst X: .        (beachte den Punkt!)
#
#  Ins Hauptverzeichnis gelegt und ausführt (beachte den Punkt!), dann bekommst Du zusätzlich 
#  zu dem von Windows vergebenen Laufwerksbuchstaben noch den (festen) Buchstaben X: für den Stick. 
#  Das ganze in eine autorun.inf eingebaut, dann sollte es theoretisch auch automatisch gehen.
#
#  Dieses Modul ist urheberrechtlich geschützte Freeware.
#  Die originale Copyright-Meldung darf nicht entfernt oder ver-
#  ändert werden. Der Quelltext darf nicht verändert werden.
#
##################################################################################################
*/

namespace StartApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ms_office_start_Click(object sender, EventArgs e)
        {

            #region MS Office Auswahlmenu (comboBox_ms_office.SelectedIndex)
            switch (comboBox_ms_office.SelectedIndex)
            {
                case 0:
                    try
                    {
                        Process.Start("WINWORD.EXE");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ist auf diesem rechner nicht installiert");

                    }
                    break;

                case 1:
                    try
                    {
                        Process.Start("EXCEL.EXE");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ist auf diesem rechner nicht installiert");

                    }
                    break;

                case 2:
                    try
                    {
                        Process.Start("ONENOTE.EXE");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ist auf diesem rechner nicht installiert");

                    }
                    break;

                case 3:
                    try
                    {
                        Process.Start("MSACCESS.EXE");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ist auf diesem rechner nicht installiert");

                    }
                    break;

                case 4:
                    try
                    {
                        Process.Start("POWERPNT.EXE");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ist auf diesem rechner nicht installiert");

                    }
                    break;

                case 5:
                    try
                    {
                        Process.Start("microsoft-edge:https://www.onenote.com/");
                    }
                    catch (Exception)
                    {
                        Process.Start("iexplore.exe", "https://www.onenote.com/");

                    }
                    break;

                case 6:
                    try
                    {
                        Process.Start("microsoft-edge:http://www.office.com/");
                    }
                    catch (Exception)
                    {
                        Process.Start("iexplore.exe", "http://www.office.com/");
                    }
                    break;

                default:
                    break;


            }
            #endregion
        }

        private void btn_open365_start_Click(object sender, EventArgs e)
        {
            #region open365 Auswahlmenu (comboBox_open365.SelectedIndex)
            switch (comboBox_open365.SelectedIndex)
            {
                case 0:
                    try
                    {
                        Process.Start("C:/Program Files (x86)/Open365/bin/open365-applet.exe");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ist auf diesem rechner nicht installiert");

                    }
                    break;

                case 1:
                    try
                    {
                        try
                        {
                            Process.Start("C:/open365/Open365/");
                        }
                        catch (Exception)
                        {
                            Process.Start("C:/open365/");

                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ist auf diesem rechner nicht installiert");

                    }
                    break;

                case 2:
                    try
                    {
                        Process.Start("C:/Program Files (x86)/CuteMarkEd/cutemarked.exe");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ist auf diesem rechner nicht installiert");

                    }
                    break;


                default:
                    break;
            }


            #endregion
        }

        private void btn_konsole_start_Click(object sender, EventArgs e)
        {
            #region cmd / konsole 

            string cmd_befehl = "/K" + tb_cmd_befehl.Text;


            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.Arguments = cmd_befehl;

            p.Start();

            #endregion
        }

        private void btn_powershell_start_Click(object sender, EventArgs e)
        {
            #region powershell Auswahl (radio_btn_powershell.Checked)
            if (radio_btn_powershell.Checked)
            {
                Process.Start("powershell.exe");
            }
            else
            {
                Process.Start("powershell_ise.exe");
            }
            #endregion
        }

        private void btn_browser_start_Click(object sender, EventArgs e)
        {
            #region Browser Auswahlmenu (comboBox_browser.SelectedIndex)
            switch (comboBox_browser.SelectedIndex)
            {
                case 0:
                    try
                    {
                        Process.Start("microsoft-edge:http://maikho.de/");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("microsoft-edge ist auf diesem Rechner nicht installiert");

                    }
                    break;

                case 1:
                    try
                    {
                        Process.Start("iexplore.exe", "http://maikho.de/");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("iexplore.exe ist auf diesem Rechner deaktiviert");

                    }
                    break;

                case 2:
                    try
                    {
                        Process.Start("firefox.exe", "http://maikho.de/");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Firefox ist auf diesem Rechner nicht installiert");

                    }
                    break;

                case 3:
                    try
                    {
                        Process.Start("vivaldi.exe", "http://maikho.de/");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Vivaldi ist auf diesem Rechner nicht installiert");

                    }
                    break;


                default:
                    break;
            }


            #endregion
        }

        private void btn_server_start_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("C:/UniServerZ/UniController.exe");
            }
            catch (Exception)
            {
                 MessageBox.Show("gibt es nicht, bitte unter C:/UniServerZ/UniController.exe anlegen! ");
            }


       }

        private void btn_filezilla_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("C:/Tools/Internet/FileZillaPortable/FileZillaPortable.exe");
            }
            catch (Exception)
            {
                MessageBox.Show("gibt es nicht, bitte unter C:/Tools/Internet/FileZillaPortable/FileZillaPortable.exe anlegen! ");
            }
        }

        private void btn_shutdown_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "/s /t 0");
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", " /r");
        }

        private void btn_win_tools_Click(object sender, EventArgs e)
        {
            #region Windows interne Tools Auswahlmenu (comboBox_win_tools.SelectedIndex)
            switch (comboBox_win_tools.SelectedIndex)
            {
                case 0:
                    try
                    {
                        Process.Start("notepad.exe");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ist auf diesem Rechner nicht installiert");

                    }
                    break;

                case 1:
                    try
                    {
                        Process.Start("write.exe");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ist auf diesem Rechner nicht installiert");

                    }
                    break;

                case 2:
                    try
                    {
                        Process.Start("calc.exe");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ist auf diesem Rechner nicht installiert");

                    }
                    break;

                case 3:
                    try
                    {
                        Process.Start("erweitern.exe");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("hier kann ruhig mehr rein");

                    }
                    break;


                default:
                    break;
            }


            #endregion
        }

        private void btn_systemtools_Click(object sender, EventArgs e)
        {
            #region Windows System Tools Auswahlmenu (comboBox_systemtools.SelectedIndex)
            switch (comboBox_systemtools.SelectedIndex)
            {
                case 0:
                    try
                    {
                        Process.Start("ms-settings:");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("funzt net");

                    }
                    break;

                case 1:
                    try
                    {
                        Process.Start("UserAccountControlSettings.exe");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("funzt net");

                    }
                    break;

                case 2:
                    try
                    {
                        Process.Start("taskmgr.exe");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("funzt net");

                    }
                    break;

                case 3:
                    try
                    {
                        Process.Start("C:/Windows/System32/msconfig.exe");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("funzt net, bitte über  win + R starten");

                    }
                    break;

                case 4:
                    try
                    {
                        Process.Start("erweitern.exe");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("kann gerne erweitert werden");

                    }
                    break;

                default:
                    break;
            }


            #endregion


        }

        private void btn_office_tools_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Tools/Office");   // öffne den tools/office ordner
        }

        private void btn_codelobster_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("ClPhpEd.exe");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("C:/Tools/Programmieren/CodelobsterPHPEdition/ClPhpEd.exe");
                }
                catch (Exception)
                {
                    MessageBox.Show("nicht vorhanden");
                }
            }

            
        }

        private void btn_bluegriffon_Click(object sender, EventArgs e)
        {
            Process.Start("C:/Tools/Programmieren/bluegriffon/bluegriffon.exe");
        }

        private void btn_manager_Click(object sender, EventArgs e)
        {
            #region Projektmanagement Auswahlmenu (comboBox_manager.SelectedIndex)
            switch (comboBox_manager.SelectedIndex)
            {
                case 0:
                    Process.Start("C:/Tools/Programmieren/devprojectPortable/DevProject.exe");
                    break;

                case 1:
                    Process.Start("C:/Tools/Programmieren/Structorizer/Structorizer.exe");
                    break;

                case 2:
                    Process.Start("C:/Tools/Programmieren/vips_win11/vips.exe");
                    break;

                default:
                    break;
            }
            #endregion
        }

        private void btn_visualstudio_ordner_Click(object sender, EventArgs e)  // cloud open365 visualstudio ordner öffnen
        {
            try
            {
                Process.Start("C:/open365/Open365/Workplace/VisualStudio_C#");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("C:/Open365/Workplace/VisualStudio_C#");
                }
                catch (Exception)
                {
                    MessageBox.Show("nicht vorhanden");
                }
            }
        }

        private void btn_www_ordner_Click(object sender, EventArgs e) // cloud open365 uniserver www ordner öffnen
        {
            try
            {
                Process.Start("C:/open365/Open365/Workplace/UniServer_www");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("C:/Open365/Workplace/UniServer_www");
                }
                catch (Exception)
                {
                    MessageBox.Show("nicht vorhanden");
                }
            }
        }

        private void btn_visualstudio_Click(object sender, EventArgs e) // vcsexpress.exe ändern
        {
            try
            {
                Process.Start("C:/Program Files (x86)/Microsoft Visual Studio 14.0/Common7/IDE/WDExpress.exe");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("C:/Program Files (x86)/Microsoft Visual Studio 12.0/Common7/IDE/WDExpress.exe");
                }
                catch (Exception)
                {
                    MessageBox.Show("nicht vorhanden");
                }
            }
        }

        private void btn_aufgaben_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("C:/open365/Open365/Workplace/noteitdown/NoteItDown.exe");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("C:/Open365/Workplace/noteitdown/NoteItDown.exe");
                }
                catch (Exception)
                {
                    MessageBox.Show("nicht vorhanden");
                }
            }
        }

        private void btn_bookme4_Click(object sender, EventArgs e)
        {
            switch (comboBox_bookme.SelectedIndex)
            {
                case 0:
                    try
                    {
                        Process.Start("C:/open365/Open365/Workplace/BookME4Portable/Data/BookME/Fachinformatik.bme");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            Process.Start("C:/Open365/Workplace/BookME4Portable/Data/BookME/Fachinformatik.bme");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("nicht vorhanden");
                        }
                    }
                    break;

                case 1:
                    try
                    {
                        Process.Start("C:/open365/Open365/Workplace/BookME4Portable/Data/BookME/Programmieren.bme");
                    }
                    catch (Exception)
                    {
                        try
                        {
                            Process.Start("C:/Open365/Workplace/BookME4Portable/Data/BookME/Programmieren.bme");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("nicht vorhanden");
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        private void btn_kalender_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("C:/open365/Open365/Workplace/Kalenderchen6/Kalenderchen.exe");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("C:/Open365/Workplace/Kalenderchen6/Kalenderchen.exe");
                }
                catch (Exception)
                {
                    MessageBox.Show("nicht vorhanden");
                }
            }
        }

        private void btn_keepass_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("C:/open365/Open365/Workplace/KeePass-2.30/Passwoerter.kdbx");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("C:/Open365/Workplace/KeePass-2.30/Passwoerter.kdbx");
                }
                catch (Exception)
                {
                    MessageBox.Show("nicht vorhanden");
                }
            }
        }

        private void btn_farmanager_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("C:/open365/Open365/Workplace/Far_Manager/Far.exe");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("C:/Open365/Workplace/Far_Manager/Far.exe");
                }
                catch (Exception)
                {
                    MessageBox.Show("nicht vorhanden");
                }
            }
        }

        private void btn_viona_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("C:/open365/Open365/Workplace/viona.exe");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("C:/Open365/Workplace/viona.exe");
                }
                catch (Exception)
                {
                    MessageBox.Show("nicht vorhanden");
                }
            }
        }
    }
}

/*  TODO_Liste

    windows system tools auswahl, da funst msconfig nicht (was tun ???)

    subst x laufwerk vieleicht noch einbauen zweck stickbenutzung

    vcsexpress.exe ändern

*/
