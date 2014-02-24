using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Mono.Data.Sqlite;
using System.IO;
using System.Text;
using System.Data;

namespace ZumaKeuzesContrast2
{
	public partial class MainMenu : UIViewController
	{
	

		public MainMenu () : base ("MainMenu", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		MainViewController4 viewController;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Zuma Keuzes version 1.1
			// database concept in progress!


			//Create's a db if there isn't one already with a table to handle the Menu segement button options
			Create_Zuma_DB();

			btnGo.TouchUpInside += (sender, e) => {

				int segmetDifficultyLevel = scChoice.SelectedSegment;
				int segmetType = scSingleChoiceOptions.SelectedSegment;

				enter_scValue(segmetDifficultyLevel, segmetType);

				if(viewController == null)
				{
					viewController = new MainViewController4();
				}

				NavigationController.PushViewController(viewController, false);

			};
		}

		public void Create_Zuma_DB()
		{
			var documents = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var pathToDatebase = Path.Combine (documents, "db_Zuma_Keuzes.db");
			SqliteConnection.CreateFile (pathToDatebase);

			var connectionString = String.Format ("Data source={0};Version=3", pathToDatebase);
			using (var conn = new SqliteConnection (connectionString)) {

				conn.Open ();
				using (var cmd = conn.CreateCommand ()) {

					cmd.CommandText = "CREATE TABLE MenuOptions (MenuOptionsID INTEGER PRIMARY KEY AUTOINCREMENT, scFirst INTEGER, scSecond INTEGER)";
					cmd.CommandType = CommandType.Text;
					cmd.ExecuteNonQuery ();
				}

			}
		}

		public void enter_scValue(int scFirst, int scSecond)
		{
			var varScFirst = scFirst;
			var varScSecond = scSecond;

			var documents = Environment.GetFolderPath (Environment.SpecialFolder.Personal);
			var pathToDatebase = Path.Combine (documents, "db_Zuma_Keuzes.db");
			//SqliteConnection.CreateFile (pathToDatebase);

			var connectionString = String.Format ("Data source={0};Version=3", pathToDatebase);
			using (var conn = new SqliteConnection (connectionString)) {

				conn.Open ();

				using (var cmd = conn.CreateCommand ()) {

					cmd.CommandText = "INSERT INTO MenuOptions (scFirst, scSecond) VALUES (@First, @Second)";
					cmd.Parameters.AddWithValue ("@First", varScFirst);
					cmd.Parameters.AddWithValue ("@Second", varScSecond);
					//cmd.CommandType = CommandType.Text;
					cmd.ExecuteNonQuery ();

				}


//				string stm = "SELECT * FROM MenuOptions";
//
//				using (SqliteCommand cmd = new SqliteCommand(stm, conn))
//				{
//					using (SqliteDataReader rdr = cmd.ExecuteReader())
//					{
//						while (rdr.Read()) {
//							Console.WriteLine (rdr["MenuOptionsID"] + " " + rdr["scType"]);
//						}
//					}
//
//				}


			}

		}

		public override void ViewWillAppear (bool animated) {
			base.ViewWillAppear (animated);
			this.NavigationController.SetNavigationBarHidden (true, animated);
		}

		public override void ViewWillDisappear (bool animated) {
			base.ViewWillDisappear (animated);
			this.NavigationController.SetNavigationBarHidden (false, animated);
		}
	}
}