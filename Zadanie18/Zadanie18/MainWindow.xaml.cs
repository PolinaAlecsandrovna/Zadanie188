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

namespace Zadanie18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Book> _allBooks = new List<Book>();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new LibraryDBEntities())
                {
                    _allBooks = db.Books.Include("Genres").ToList();
                }

                DataGridBooks.ItemsSource = _allBooks;

                var genres = _allBooks
                    .Where(b => b.Genres != null && b.Genres.Name != null)
                    .Select(b => b.Genres.Name)
                    .Distinct()
                    .Cast<string>()
                    .ToList();

                genres.Insert(0, "Все жанры");
                CmbGenre.ItemsSource = genres;
                CmbGenre.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UpdateDataGrid()
        {
            IEnumerable<Book> filteredList = _allBooks;

            string searchText = TxtSearch.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(searchText))
            {
                filteredList = filteredList.Where(b => (b.Title != null && b.Title.ToLower().Contains(searchText))
                                                    || (b.Author != null && b.Author.ToLower().Contains(searchText)));
            }

            if (CmbGenre.SelectedItem != null)
            {
                string selectedGenre = CmbGenre.SelectedItem.ToString();
                if (selectedGenre != "Все жанры")
                {
                    filteredList = filteredList.Where(b => b.Genres != null && b.Genres.Name == selectedGenre);
                }
            }

            if (CmbSort.SelectedItem is ComboBoxItem selectedSortItem)
            {
                switch (selectedSortItem.Content.ToString())
                {
                    case "По названию (А-Я)":
                        filteredList = filteredList.OrderBy(b => b.Title);
                        break;
                    case "По названию (Я-А)":
                        filteredList = filteredList.OrderByDescending(b => b.Title);
                        break;
                    case "По автору":
                        filteredList = filteredList.OrderBy(b => b.Author);
                        break;
                    default:
                        break;
                }
            }

            DataGridBooks.ItemsSource = filteredList.ToList();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void CmbGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateDataGrid();
        }

        private void DataGridBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}