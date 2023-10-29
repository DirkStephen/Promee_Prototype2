using System.Diagnostics.Metrics;
using CommunityToolkit.Maui.Views;
using Firebase.Database;
using Firebase.Database.Query;
using Microsoft.Maui.Storage;
using Promee_Prototype2.Model;

namespace Promee_Prototype2.CreateTask;

public partial class AddtaskPopup : Popup
{
    FirebaseClient _firebaseClient = new FirebaseClient("https://promee-abd70-default-rtdb.asia-southeast1.firebasedatabase.app/");
    public string Task { get; set; }
    public string Note { get; set; }
    public DateTime ScheduleDate { get; set; }
    public TimeSpan STime { get; set; }
    public TimeSpan ETime { get; set; }

    public AddtaskPopup()
    {

        InitializeComponent();

    }

    private void OnCreateButtonClicked(object sender, EventArgs e)
    {

        _firebaseClient.Child("Todo").PostAsync(new TodoItem
        {
            Task = EnterTask.Text,
            Note = EnterNote.Text,
            ScheduleDate = InputDate.Date.Date,
            STime = InputStartTime.Time,
            ETime = InputEndTime.Time
        });
        this.Close();
    }
    private void OnCancelButtonClicked(object sender, EventArgs e)
    {
        this.Close();
    }
}