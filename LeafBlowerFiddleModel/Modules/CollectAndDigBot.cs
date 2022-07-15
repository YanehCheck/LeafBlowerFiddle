using System.Threading;
using System.Threading.Tasks;

namespace LeafBlowerFiddleModel.Modules {
    public class CollectAndDigBot {
        public bool IsEnabled { get; set; }
        private CancellationTokenSource TokenSource { get; set; }

        public void Toggle(int delay) {
            if(!IsEnabled) {
                TokenSource = new CancellationTokenSource();
                Task.Run(() => Action(delay));
            }
            else {
                TokenSource.Cancel();
            }

            IsEnabled = !IsEnabled;
        }

        private void Action(int delay) {
            while(true) {
                RECT size  = Window.GetSize();
                for(int i = 0; i < size.Width; i += 100) {
                    if(TokenSource.IsCancellationRequested) { return; }
                    InputWrapper.Input(InputAction.MoveMouse, 0, InputWrapper.MakeLParam(10, i));
                    Thread.Sleep(delay);
                    InputWrapper.Input(InputAction.MoveMouse, 0, InputWrapper.MakeLParam(size.Height - 10, i));
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
