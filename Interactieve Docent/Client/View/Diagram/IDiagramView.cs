using System.Collections.Generic;

namespace Client.View.Diagram
{
    public interface IDiagramView : IView
    {
        void Make(List<int> values, List<string> answerNames, string question);
        void Close();
        void Show();
    }
}
