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

namespace StickStarter
{
    public partial class Form1 : Form
    {
        // String des Pfades für das Laufwerk
        string mystick = AppDomain.CurrentDomain.BaseDirectory;
        
        public Form1()
        {
            InitializeComponent();
        }

        // Menüpunkt Office
        #region Office
        private void libreOfficeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Start LibreOffice
            Process.Start(mystick + @"/Apps/LibreOfficePortable/LibreOfficePortable.exe");
        }

        private void bookMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Start bookme
            Process.Start(mystick + @"/Apps/BookME4Portable/BookME4Portable.exe");
        }

        private void cutMarkEdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Start cutemark
            Process.Start(mystick + @"/Apps/CuteMarkEdPortable/CuteMarkEdPortable.exe");
        }

        private void noteitdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // noteitdown
            Process.Start(mystick + @"/Apps/noteitdown/NoteItDown.exe");
        }

        private void scribblePapersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Scribble Papers
            Process.Start(mystick + @"/Apps/Scribble Papers/ScPapers.exe");
        }
#endregion

        // Menüpunkt Entwicklung
        #region Entwicklung
        private void bracketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // BracketsPortable
            Process.Start(mystick + @"/Apps/BracketsPortable/BracketsPortable.exe");
        }

        private void codeLobsterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // CodelobsterPHPEdition
            Process.Start(mystick + @"/Apps/CodelobsterPHPEdition/ClPhpEd.exe");
        }

        private void eclipseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // eclipse
            Process.Start(mystick + @"/Apps/eclipse/eclipse.exe");
        }

        private void eclipsePortableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // eclipse
            Process.Start(mystick + @"/Apps/EclipsePortable/eclipse.exe");
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Notepad++Portable
            Process.Start(mystick + @"/Apps/Notepad++Portable/Notepad++Portable.exe");
        }

        private void xLazarusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // X-Lazarus
            Process.Start(mystick + @"/Apps/X-Lazarus/X-Lazarus.exe");
        }
#endregion
        // Menüpunkt Server
        #region Server
        private void miniServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // server_start
            Process.Start(mystick + @"/Server/00_mini_server/server_start.bat");
        }

        private void stopServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // server_start
            Process.Start(mystick + @"/Server/00_mini_server/server_stop.bat");
        }

        private void uniServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Uniserver
            Process.Start(mystick + @"/Server/UniServerZ/UniController.exe");
        }
        #endregion
        // Menüpunkt shutdown
        #region shutdown
        private void shutdownToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", "/s /t 0");
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown.exe", " /r");
        }
        #endregion
        // Menüpunkt WebApps
        #region WebApps
        private void maikhodeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("microsoft-edge:http://maikho.de/");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("iexplore.exe", "http://maikho.de/");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ich kann leider keinen Browser öffnen");
                }  
            }            
        
        }

        private void mozillaThimbreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("microsoft-edge:https://thimble.mozilla.org/de/");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("iexplore.exe", "https://thimble.mozilla.org/de/");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ich kann leider keinen Browser öffnen");
                }
            }         
        }

        private void outlookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("microsoft-edge:https://outlook.com/");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("iexplore.exe", "https://outlook.com/");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ich kann leider keinen Browser öffnen");
                }
            }         
        }

        private void notizenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("microsoft-edge:https://keep.google.com/u/0/");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("iexplore.exe", "https://keep.google.com/u/0/");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ich kann leider keinen Browser öffnen");
                }
            }         
        }

        private void lesezeichenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("microsoft-edge:https://www.google.de/bookmarks/");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("iexplore.exe", "https://www.google.de/bookmarks/");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ich kann leider keinen Browser öffnen");
                }
            }
        }

        private void maikhoffmanneuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("microsoft-edge:http://maikhoffmann.eu/");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("iexplore.exe", "http://maikhoffmann.eu/");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ich kann leider keinen Browser öffnen");
                }
            }
        }
        private void wikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("microsoft-edge:http://maikhoffmann.eu/wiki/");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("iexplore.exe", "http://maikhoffmann.eu/wiki/");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ich kann leider keinen Browser öffnen");
                }
            }
        }

        private void nemexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("microsoft-edge:http://maikhoffmann.eu/nemex/");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("iexplore.exe", "http://maikhoffmann.eu/nemex/");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ich kann leider keinen Browser öffnen");
                }
            }
        }

        private void myownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("microsoft-edge:http://maikhoffmann.eu/myown/");
            }
            catch (Exception)
            {
                try
                {
                    Process.Start("iexplore.exe", "http://maikhoffmann.eu/myown/");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ich kann leider keinen Browser öffnen");
                }
            }
        }
        #endregion
        // Menüpunkt Dokumente
        private void uniserverWwwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Ordner uniserver www
            Process.Start(mystick + @"/Server/UniServerZ/www");
        }

        private void scripteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(mystick + @"/scripte");
        }

        private void mylibaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(mystick + @"/my_libary");
        }

        private void dokumenteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start(mystick + @"/Dokumente");
        }

        private void privatewikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(mystick + @"/Private-wiki");
        }

        #region Browser

        private void chromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(mystick + @"/Apps/GoogleChromePortable/GoogleChromePortable.exe");
        }

        #endregion
    }
}
/*  

// BracketsPortable
            Process.Start(mystick + @"/Apps/BracketsPortable/BracketsPortable.exe");


*/