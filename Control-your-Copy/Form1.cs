using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace Control_your_Copy
{
    public partial class Form1 : Form
    {
        private IKeyboardMouseEvents globalHook;
        private Form popupForm;
        private System.Timers.Timer hideTimer;

        public Form1()
        {
            InitializeComponent();
            InitializePopup();
            SubscribeGlobalHook();
        }

        private void InitializePopup()
        {
            popupForm = new Form
            {
                FormBorderStyle = FormBorderStyle.None,
                StartPosition = FormStartPosition.Manual,
                TopMost = true,
                BackColor = Color.Black,
                ForeColor = Color.White,
                ShowInTaskbar = false,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            var label = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White,
                BackColor = Color.Black,
                Padding = new Padding(8)
            };

            popupForm.Controls.Add(label);
            var _ = popupForm.Handle; // force handle creation

            hideTimer = new System.Timers.Timer(1000); // 1 sec
            hideTimer.Elapsed += (s, e) =>
            {
                if (popupForm != null && popupForm.IsHandleCreated)
                {
                    popupForm.Invoke(() => popupForm.Hide());
                }
                hideTimer.Stop();
            };
        }

        private void SubscribeGlobalHook()
        {
            globalHook = Hook.GlobalEvents();
            globalHook.KeyDown += GlobalHook_KeyDown;
        }

        private void GlobalHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                try
                {
                    string copiedText = Clipboard.GetText();
                    ShowPopupNearCursor("Copied");
                }
                catch
                {
                    // Sometimes clipboard throws exceptions
                    ShowPopupNearCursor("Copied");
                }
            }
        }

        private void ShowPopupNearCursor(string text)
        {
            if (!popupForm.IsHandleCreated)
                return;

            popupForm.Invoke(() =>
            {
                var mousePos = Cursor.Position;

                var label = popupForm.Controls[0] as Label;
                label.Text = text.Length > 150 ? text.Substring(0, 150) + "..." : text;

                popupForm.Location = new Point(mousePos.X + 10, mousePos.Y + 10);
                popupForm.Show();
                hideTimer.Stop();
                hideTimer.Start();
            });
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            globalHook?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
