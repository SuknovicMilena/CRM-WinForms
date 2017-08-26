using CRM.Desktop.Views;

namespace CRM.Desktop.Presenter
{
    public class Presenter<T> where T : IView
    {
        /// <summary>
        /// Constructor. Sets the view.
        /// </summary>
        /// <param name="view">The view.</param>
        public Presenter(T view)
        {
            View = view;
        }

        /// <summary>
        /// Gets and sets the view.
        /// </summary>
        protected T View { get; private set; }
    }
}
