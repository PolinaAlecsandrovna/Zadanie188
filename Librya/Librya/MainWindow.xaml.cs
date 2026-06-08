using Librya.Models;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Librya
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Books> _allBooks = new List<Books>();
        private BooksEntities db = null;

        public MainWindow()
        {
            InitializeComponent();

            try
            {
                db = BooksEntities.GetContext();
                _allBooks = db.Books.Include("Genres").ToList();

                DataGridBooks.ItemsSource = _allBooks;

                var genres = _allBooks
                    .Where(b => b.Genres != null && b.Genres.Name != null)
                    .Select(b => b.Genres.Name)
                    .Distinct()
                    .Cast<string>()
                    .ToList();

                List<string> sort = new List<string>() {
                       "Без сортировки",
                       "По названию (А-Я)",
                       "По названию (Я-А)",
                       "По автору",
                       "По году публикации (возрастание)",
                       "По году публикации (убывание)"
                };

                
                CmbSort.ItemsSource = sort;
                CmbSort.SelectedIndex = 0;

                genres.Insert(0, "Все жанры");
                CmbGenre.ItemsSource = genres;
                CmbGenre.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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

        private void UpdateDataGrid()
        {


            IEnumerable<Books> filteredList = db.Books.Include("Genres").ToList();

            string searchText = TxtSearch.Text.Trim().ToLower();

            if (!string.IsNullOrEmpty(searchText))
            {
                filteredList = filteredList.Where(b =>

                    (b.Title != null && b.Title.ToLower().Contains(searchText)) ||

                    (b.Author != null && b.Author.ToLower().Contains(searchText)));
            }

            if (CmbGenre.SelectedItem != null)
            {
                if (CmbGenre.SelectedItem is string selectedGenre)
                {
                    if (selectedGenre != "Все жанры")
                    {
                        filteredList = filteredList.Where(b => b.Genres != null && b.Genres.Name == selectedGenre);
                    }
                }
            }

            if (CmbSort.SelectedItem != null)
            {
                string sortBy = CmbSort.SelectedValue.ToString();
                switch (sortBy)
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
                    case "По году публикации (возрастание)":
                        filteredList = filteredList.OrderBy(b => b.YearOfPublication);
                        break;
                    case "По году публикации (убывание)":
                        filteredList = filteredList.OrderByDescending(b => b.YearOfPublication);
                        break;
                    default:
                        break;
                }
            }

            DataGridBooks.ItemsSource = filteredList.ToList(); 
        }
        private void DataGridBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridBooks.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите книгу для редактирования.", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Books selectedBook = (Books)DataGridBooks.SelectedItem;
            var editWindow = new AddEditBookWindow(db, selectedBook);
            if (editWindow.ShowDialog() == true)
            {
                RefreshDataGrid();
                UpdateGenresFilter();
                MessageBox.Show("Книга успешно обновлена!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridBooks.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите книгу для удаления.", "Внимание",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Books selectedBook = (Books)DataGridBooks.SelectedItem;

            MessageBoxResult result = MessageBox.Show($"Вы уверены, что хотите удалить книгу \"{selectedBook.Title}\"?",
                "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    db.Books.Remove(selectedBook);
                    db.SaveChanges();
                    RefreshDataGrid();
                    UpdateGenresFilter();
                    MessageBox.Show("Книга успешно удалена!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении: {ex.Message}", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddEditBookWindow(db);
            if (addWindow.ShowDialog() == true)
            {
                RefreshDataGrid();
                UpdateGenresFilter();
                MessageBox.Show("Книга успешно добавлена!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        private void RefreshDataGrid()
        {
            _allBooks = db.Books.Include("Genres").ToList();
            UpdateDataGrid();
        }
        private void UpdateGenresFilter()
        {
            var genres = db.Books
                .Where(b => b.Genres != null && b.Genres.Name != null)
                .Select(b => b.Genres.Name)
                .Distinct()
                .ToList();

            string selectedGenre = CmbGenre.SelectedItem?.ToString();
            genres.Insert(0, "Все жанры");
            CmbGenre.ItemsSource = genres;

            if (genres.Contains(selectedGenre))
                CmbGenre.SelectedItem = selectedGenre;
            else
                CmbGenre.SelectedIndex = 0;
        }

    }
}

