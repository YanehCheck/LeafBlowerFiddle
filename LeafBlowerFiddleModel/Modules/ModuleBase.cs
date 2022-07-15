using System.Threading;
using System.Threading.Tasks;

namespace LeafBlowerFiddleModel.Modules {
    public abstract class ModuleBase {
        public bool IsEnabled { get; set; }
        protected CancellationTokenSource TokenSource { get; set; }

        public virtual void Toggle() {
            if(!IsEnabled) {
                TokenSource = new CancellationTokenSource();
                Task.Run(Action);
            }
            else {
                TokenSource.Cancel();
            }

            IsEnabled = !IsEnabled;
        }

        protected virtual void Action() { }
    }
}
