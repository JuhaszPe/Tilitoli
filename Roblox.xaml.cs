using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TiliToli
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public Roblox()
		{
			InitializeComponent();
			Shake();
      Button zerobutton = (Button)FindName("btn0");
      zeroButton.Visibility = Visibility.Hidden;
		}

		int steps = 0;
		private void btn_Click(object sender, RoutedEventArgs e)
		{
			Button clickedButton = sender as Button;
			Button zeroButton = (Button)FindName("btn0");
			int horizontalDistance = Math.Abs((int)(clickedButton.Margin.Left - zeroButton.Margin.Left));
			int verticalDistance = Math.Abs((int)(clickedButton.Margin.Top - zeroButton.Margin.Top));
			if ((horizontalDistance < 300 && verticalDistance == 0) || (verticalDistance < 300 && horizontalDistance == 0))
			{
				var aux = clickedButton.Margin;
				clickedButton.Margin = zeroButton.Margin;
				zeroButton.Margin = aux;
				steps++;
				stepsCounter.Text = Convert.ToString(steps);
			}
			if (button0.Margin.Left == 300 && button0.Margin.Top == 300 && btn1.Margin.Left == 70 && btn1.Margin.Top == 100 && btn2.Margin.Left == 200 && btn2.Margin.Top == 100 && button3.Margin.Left == 330 && button3.Margin.Top == 100 && button4.Margin.Left == 100 && button4.Margin.Top == 200 && button5.Margin.Left == 200 && button5.Margin.Top == 200 && button6.Margin.Left == 330 && button6.Margin.Top == 200 && button7.Margin.Left == 100 && button7.Margin.Top == 300 && button8.Margin.Left == 200 && button8.Margin.Top == 300)
			{
				MessageBox.Show("grat nyertél!");
			}
		}

		public void Shake()
		{
			Random rand = new Random();
			for (int i = 0; i < 10; i++)
			{
				randomNumber = r.Next(1, 10);
                   string Button = "Button" + randomNumber;
                   Button RandomButton = (Button)FindName(btn);
                   int vtav = Math.Abs((int)(RandomButton.Margin.Left - btn.Margin.Left));
                   int ftav = Math.Abs((int)(RandomButton.Margin.Top - btn0.Margin.Top));
                   if ((vtav < 300 && ftav == 0) || (ftav < 300 && vtav == 0))
					var aux = randomButton.Margin;
					randomButton.Margin = zeroButton.Margin;
					zeroButton.Margin = aux;
				}
			}
		}

		private void NewGame_Click(object sender, RoutedEventArgs e)
		{
			steps = 0;
			stepsCounter.Text = Convert.ToString(steps);
			Shake();
		}
	}while (run != Shake);
}
