using System.Threading;
using System.Threading.Tasks;

namespace LeafBlowerFiddleModel.Modules {
    public static class CollectAndDigBot {
        public static bool IsEnabled { get; set; }
        private static CancellationTokenSource TokenSource { get; set; }

        public static void Toggle(int delay) {
            if(!IsEnabled) {
                TokenSource = new CancellationTokenSource();
                Task.Run(() => Action(delay));
            }
            else {
                TokenSource.Cancel();
            }

            IsEnabled = !IsEnabled;
        }

        private static void Action(int delay) {
            while(true) {
                RECT size  = Window.GetSize();
                for(int i = 0; i < size.Width; i += 100) {
                    if(TokenSource.IsCancellationRequested) { return; }
                    InputWrapper.Input(InputAction.MoveMouse, 0, InputWrapper.MakeLParam(20, i));
                    Thread.Sleep(delay);
                    InputWrapper.Input(InputAction.MoveMouse, 0, InputWrapper.MakeLParam(size.Height - 20, i));
                    Thread.Sleep(delay);
                }
                InputWrapper.Input(InputAction.MoveMouse, 0, InputWrapper.MakeLParam(size.Height / 2, size.Width / 2));
                Thread.Sleep(100);
                InputWrapper.Input(InputAction.LeftButtonDown);
                Thread.Sleep(100);
                InputWrapper.Input(InputAction.LeftButtonUp);
            }
        }
    }
}
