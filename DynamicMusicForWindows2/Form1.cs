using Newtonsoft.Json;
using Ownskit.Utils;
using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Input;

namespace DynamicMusicForWindows
{
    public enum activity
    {
        Idle, Activity
    }

    public partial class Form1 : Form
    {
        //Static Fields
        /// <summary>
        /// The main instance
        /// </summary>
        public static Form1 instance;
        /// <summary>
        /// Time since application Start
        /// </summary>
        public static double timeUntilStart { get; set; }
        /// <summary>
        /// The number of interaction
        /// </summary>
        public static int keyInteractions { get; set; }
        /// <summary>
        /// The current Flow
        /// </summary>
        public static float directFlow { get; set; }

        //Settings
        public class settings
        {
            /// <summary>
            /// The Idle State Music Path (Leave "" to Default Music)
            /// </summary>
            public string idleMusicPath = "";
            /// <summary>
            /// The Activity State Music Path (Leave "" to Default Music)
            /// </summary>
            public string runMusicPath = "";
            public float volume = 100;
        }
        /// <summary>
        /// The settings of application
        /// </summary>
        public static settings Settings = new settings();
        /// <summary>
        /// The default save location of settings.ini file
        /// </summary>
        public static string defaultSaveFileLocation = Application.StartupPath + @"\settings.ini";


        //Private fields
        KeyboardListener KListener = new KeyboardListener();
        Timer timer;



        public Form1()
        {
            //Initialize and load settings of app
            InitializeComponent();
            LoadSettings(defaultSaveFileLocation);
            SetWindow(10);

            //Perform 30ms update
            timer = new Timer();
            timer.Tick += new EventHandler(Update);
            timer.Interval = 30; // in miliseconds
            timer.Start();

            //Register keyboard and load music
            ReloadMusics();
            KListener.KeyDown += new RawKeyEventHandler(OnKeyPressed);
            instance = this;
        }


        /// <summary>
        /// Define the skin of window
        /// </summary>
        /// <param name="borderRoundness"></param>
        public void SetWindow(int borderRoundness)
        {
            FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, borderRoundness, borderRoundness));
        }

        /// <summary>
        /// Called every 30ms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update(object sender, EventArgs e)
        {
            timeUntilStart += 0.01f;
            directFlow -= 0.4f;
            if (directFlow <= 0)
            {
                directFlow = 0;
            }

            if (directFlow >= 100)
            {
                directFlow = 100;
            }

            int directIdleValue = (int)(100 - directFlow);
            float volumeValue = Volume.Value / 100.0f;

            Debug.Text = (volumeValue * 100).ToString();

            //IdlePlayer.settings.volume = (int)((100 - directFlow) * volValue);
            IdlePlayer.settings.volume = (int)(directIdleValue * (volumeValue * 0.7f));
            RunPlayer.settings.volume = (int)(directFlow * volumeValue);
        }

        /// <summary>
        /// Called every time when some key is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        void OnKeyPressed(object sender, RawKeyEventArgs args)
        {
            if (args.Key != Key.None)
            {
                keyInteractions += 1;
                directFlow += 1.3f;
                directFlow *= 1.2f;
            }

        }


        #region Cheking
        /// <summary>
        /// Check Idle and Activity Path musics
        /// </summary>
        public static void CheckUp()
        {
            if (string.IsNullOrEmpty(Settings.idleMusicPath) || string.IsNullOrEmpty(Settings.runMusicPath))
            {
                Settings.idleMusicPath = Application.StartupPath + @"\Resources\Idle.wav";
                Settings.runMusicPath = Application.StartupPath + @"\Resources\Activity.wav";
            }
            CheckIfMusicPathIsValid(Settings.runMusicPath, activity.Idle);
            CheckIfMusicPathIsValid(Settings.runMusicPath, activity.Activity);
        }
        /// <summary>
        /// Check if path is a valid path and open the file Dialog
        /// </summary>
        /// <param name="path"></param>
        /// <param name="_activity"></param>
        public static void CheckIfMusicPathIsValid(string path, activity _activity)
        {
            switch (_activity)
            {
                case activity.Idle:
                    if (!File.Exists(path))
                    {
                        Settings.idleMusicPath = OpenMusic("Select Idle Music");
                    }
                    break;
                case activity.Activity:
                    if (!File.Exists(path))
                    {
                        Settings.idleMusicPath = OpenMusic("Select Activity Music");
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion





        /// <summary>
        /// Reload, update and play sound file, after save it
        /// </summary>
        public void ReloadMusics()
        {
            CheckUp();
            Idle.nameTitle = Path.GetFileNameWithoutExtension(Settings.idleMusicPath);
            Run.nameTitle = Path.GetFileNameWithoutExtension(Settings.runMusicPath);
            PerformMusic(IdlePlayer, Settings.idleMusicPath);
            PerformMusic(RunPlayer, Settings.runMusicPath);
            SaveSettings(defaultSaveFileLocation);
        }
        /// <summary>
        /// Direct play some music on Media Player
        /// </summary>
        /// <param name="target"></param>
        /// <param name="path"></param>
        public void PerformMusic(AxWMPLib.AxWindowsMediaPlayer target, string path)
        {
            target.URL = path;
            target.settings.playCount = int.MaxValue;
            target.Visible = false;
            target.settings.autoStart = true;
        }

        /// <summary>
        /// Set some music to play
        /// </summary>
        /// <param name="activity">The state to change</param>
        public static void SelectMusicToPlay(activity activity)
        {
            switch (activity)
            {
                case activity.Idle:
                    Settings.idleMusicPath = OpenMusic("Select the Idle Music");
                    break;
                case activity.Activity:
                    Settings.runMusicPath = OpenMusic("Select the Activity Music");
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Open some muisc dialog
        /// </summary>
        /// <param name="title">the title of "Open file Dialog"</param>
        /// <returns></returns>
        public static string OpenMusic(string title)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = title;
            openFileDialog.Filter = "Mp3 files (*.mp3)|*.mp3| Wave files (*.wav)|*.wav| All files (*.*)|*.*";
            openFileDialog.ShowDialog();
            return openFileDialog.FileName;
        }



        /// <summary>
        /// Get a string settings JSON file format
        /// </summary>
        /// <returns></returns>
        public string GetJSON()
        {
            return JsonConvert.SerializeObject(Settings, Formatting.Indented);
        }
        /// <summary>
        /// Apply some JSON on Settings
        /// </summary>
        /// <param name="JSON"></param>
        /// <returns></returns>
        public settings GetFromJSON(string JSON)
        {
            return JsonConvert.DeserializeObject<settings>(JSON);
        }

        /// <summary>
        /// Save settings on file at path
        /// </summary>
        /// <param name="Path">Path to save</param>
        public void SaveSettings(string Path)
        {
            File.WriteAllText(Path, GetJSON());
        }

        /// <summary>
        /// Check and load some file on path
        /// </summary>
        /// <param name="Path"></param>
        public void LoadSettings(string Path)
        {
            if (File.Exists(Path)) { Settings = GetFromJSON(File.ReadAllText(Path)); }
            Volume.Value = (int)Settings.volume;
        }



        //Form outputs

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Dynamic Music for Windows";
            notifyIcon1.BalloonTipText = "App move to system tray";
            notifyIcon1.Text = "Dynamic Music For Windows\nDouble click to open";

        }

        private void notifyIcon1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.Show();
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MoreOptions.Visible = !MoreOptions.Visible;
        }

        private void CloseMoreOps(object sender, EventArgs e)
        {
            MoreOptions.Visible = false;
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowInTaskbar = false;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.BackColor = System.Drawing.Color.FromArgb(255, 50, 50, 50);
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackColor = System.Drawing.Color.FromArgb(255, 32, 32, 32);
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.BackColor = System.Drawing.Color.FromArgb(255, 50, 50, 50);
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackColor = System.Drawing.Color.FromArgb(255, 32, 32, 32);
        }
    }
}
