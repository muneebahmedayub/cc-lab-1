using System.Collections.ObjectModel;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task02
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public ObservableCollection<Person> People { get; set; }

		public MainWindow()
		{
			InitializeComponent();
			People = new ObservableCollection<Person>();
			PeopleDataGrid.ItemsSource = People;
		}

		private void AddPerson_Click(object sender, RoutedEventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(NameTextBox.Text) && int.TryParse(AgeTextBox.Text, out int age))
			{
				People.Add(new Person { Name = NameTextBox.Text, Age = age });
				NameTextBox.Clear();
				AgeTextBox.Clear();
			}
			else
			{
				MessageBox.Show("Please enter a valid name and age.");
			}
		}
		public class Person
		{
			public string Name { get; set; }
			public int Age { get; set; }
		}
	}
}