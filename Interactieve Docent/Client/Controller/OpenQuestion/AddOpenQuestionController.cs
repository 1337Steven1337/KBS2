using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Factory;
using Client.Model;
using Client.View;

namespace Client.Controller.OpenQuestion
{
    public class AddOpenQuestionController : AbstractController<Model.OpenQuestion>
    {
        private IAddView<Model.OpenQuestion> View { get; set; }

        #region Constructors
        public AddOpenQuestionController(IAddView<Model.OpenQuestion> view)
        {
            this.SetView(view);
            this.View.SetController(this);
        }
        #endregion

        public override IView GetView()
        {
            throw new NotImplementedException();
        }

        public override void SetBaseFactory(IFactory<Model.OpenQuestion> baseFactory)
        {
            throw new NotImplementedException();
        }

        public override void SetView(IView view)
        {
            this.View = (IAddView<Model.OpenQuestion>)view;
        }
    }
}
