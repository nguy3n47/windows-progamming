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
using System.Windows.Shapes;
using System.ComponentModel;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for yc11_ListView.xaml
    /// </summary>
    public partial class yc11_ListView : Window
    {
        private GridViewColumnHeader listViewSortCol = null;
        private SortAdorner listViewSortAdorner = null;

        public yc11_ListView()
        {
            InitializeComponent();
            List<User6> items = new List<User6>();
            items.Add(new User6() { Name = "John Doe", Age = 42, Sex = SexType1.Male });
            items.Add(new User6() { Name = "Jane Doe", Age = 39, Sex = SexType1.Female });
            items.Add(new User6() { Name = "Sammy Doe", Age = 13, Sex = SexType1.Male });
            items.Add(new User6() { Name = "Donna Doe", Age = 13, Sex = SexType1.Female });
            lvUsers.ItemsSource = items;
        }
        private void lvUsersColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader column = (sender as GridViewColumnHeader);
            string sortBy = column.Tag.ToString();
            if (listViewSortCol != null)
            {
                AdornerLayer.GetAdornerLayer(listViewSortCol).Remove(listViewSortAdorner);
                lvUsers.Items.SortDescriptions.Clear();
            }

            ListSortDirection newDir = ListSortDirection.Ascending;
            if (listViewSortCol == column && listViewSortAdorner.Direction == newDir)
                newDir = ListSortDirection.Descending;

            listViewSortCol = column;
            listViewSortAdorner = new SortAdorner(listViewSortCol, newDir);
            AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortAdorner);
            lvUsers.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));
        }
    }

	public enum SexType1 { Male, Female };
	public class User6
	{
		public string Name { get; set; }

		public int Age { get; set; }

		public string Mail { get; set; }

		public SexType1 Sex { get; set; }
	}

	public class SortAdorner : Adorner
	{
		private static Geometry ascGeometry =
			Geometry.Parse("M 0 4 L 3.5 0 L 7 4 Z");

		private static Geometry descGeometry =
			Geometry.Parse("M 0 0 L 3.5 4 L 7 0 Z");

		public ListSortDirection Direction { get; private set; }

		public SortAdorner(UIElement element, ListSortDirection dir)
			: base(element)
		{
			this.Direction = dir;
		}

		protected override void OnRender(DrawingContext drawingContext)
		{
			base.OnRender(drawingContext);

			if (AdornedElement.RenderSize.Width < 20)
				return;

			TranslateTransform transform = new TranslateTransform
				(
					AdornedElement.RenderSize.Width - 15,
					(AdornedElement.RenderSize.Height - 5) / 2
				);
			drawingContext.PushTransform(transform);

			Geometry geometry = ascGeometry;
			if (this.Direction == ListSortDirection.Descending)
				geometry = descGeometry;
			drawingContext.DrawGeometry(Brushes.Black, null, geometry);

			drawingContext.Pop();
		}
	}
}
