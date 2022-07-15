using System.Runtime.CompilerServices;
using LeafBlowerFiddleModel.Modules;

namespace LeafBlowerFiddleView;
using LeafBlowerFiddleModel;

public partial class Form1 : Form {
    public CollectAndDigBot CollectAndDigModule = new();
    public ClawBot ClawModule = new ClawBot();
    public Form1() {
        InitializeComponent();
    }
    private void buttonSearchGameWindow_Click(object sender, EventArgs e) {
        Window.SetGameHandlePtr();
        if(Window.IsGameHandlerPtrSet) {
            labelFoundGameWindow.Text = "Found";
            labelFoundGameWindow.ForeColor = Color.Lime;
        }
        else {
            labelFoundGameWindow.Text = "Not found";
            labelFoundGameWindow.ForeColor = Color.Red;
        }
    }
    private void buttonDigBot_Click(object sender, EventArgs e) {
        CollectAndDigModule.Toggle((int) numericUpDownDigAndCollectDelay.Value);
        buttonDigBot.Text = CollectAndDigModule.IsEnabled ? "Stop" : "Start";
    }

    private void buttonClawBot_Click(object sender, EventArgs e) {
        ClawModule.Toggle();
        buttonClawBot.Text = ClawModule.IsEnabled ? "Stop" : "Start";
    }

    #region Custom border and form control

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    private void MakeControlDraggableEvent(object sender, MouseEventArgs e) {
        if(e.Button == MouseButtons.Left) {
            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0);
        }
    }
    private void buttonClose_Click(object sender, EventArgs e) {
        Application.Exit();
    }

    private void buttonMinimize_Click(object sender, EventArgs e) {
        WindowState = FormWindowState.Minimized;
    }

    private void buttonTray_Click(object sender, EventArgs e) {

    }
    #endregion
}