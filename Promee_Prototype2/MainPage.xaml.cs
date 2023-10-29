using CommunityToolkit.Maui.Views;
using Firebase.Database;
using Promee_Prototype2.CreateTask;
using Promee_Prototype2.Model;
using System.Collections.ObjectModel;

namespace Promee_Prototype2
{
    public partial class MainPage : ContentPage
    {
        FirebaseClient _firebaseClient = new FirebaseClient("https://promee-abd70-default-rtdb.asia-southeast1.firebasedatabase.app/");
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;

            var collection = _firebaseClient
                .Child("Todo")
                .AsObservable<TodoItem>()
                .Subscribe((item) =>
                {
                    if (item.Object != null)
                    {
                        TodoItems.Add(item.Object);
                    }
                });

        }
        private void AddTask(object sender, EventArgs e)
        {
            this.ShowPopup(new AddtaskPopup());
        }
        public ObservableCollection<TodoItem> TodoItems { get; set; } = new ObservableCollection<TodoItem>();



        public void onTaskDelete(object sender, EventArgs e)
        {

        }

    }
}