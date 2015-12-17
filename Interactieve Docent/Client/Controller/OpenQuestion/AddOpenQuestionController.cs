using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Factory;
using Client.Model;
using Client.View;
using System.Net;

namespace Client.Controller.OpenQuestion
{
    public class AddOpenQuestionController : AbstractController<Model.OpenQuestion>
    {
        private IAddView<Model.OpenQuestion> View { get; set; }
        private OpenQuestionFactory Factory = new OpenQuestionFactory();

        #region Constructors
        public AddOpenQuestionController(IAddView<Model.OpenQuestion> view)
        {
            this.SetView(view);
            this.View.SetController(this);
        }
        #endregion

        private void CallbackSaveQuestion(Model.OpenQuestion question, HttpStatusCode status)
        {
            this.View.ShowSaveResult(question, status);
        }

        public void Save(Model.OpenQuestion question)
        {
            question.Pincode_Id = "123456";
            this.Factory.Save(question, this.View.GetHandler(), this.CallbackSaveQuestion);
        }

        public override IView GetView()
        {
            throw new NotImplementedException();
        }

        public override void SetBaseFactory(IFactory<Model.OpenQuestion> baseFactory)
        {
            this.Factory.SetBaseFactory(baseFactory);
        }

        public override void SetView(IView view)
        {
            this.View = (IAddView<Model.OpenQuestion>)view;
        }
    }
}
