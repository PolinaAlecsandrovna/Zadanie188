using Librya.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Librya
{
    public partial class AddEditBookWindow : Window
    {
        private BooksEntities _db;
        private Books _book;
        private bool _isEditMode;

        public AddEditBookWindow(BooksEntities db, Books book = null)
        {
            InitializeComponent();
            _db = db;

            LoadGenres();

            if (book != null)
            {
                _isEditMode = true;
                _book = book;
                LoadBookData();
                this.Title = "Редактирование книги";
            }
            else
            {
                _isEditMode = false;
                _book = new Books();
                this.Title = "Добавление новой книги";
            }
        }

        private void LoadGenres()
        {
            try
            {
                var genres = _db.Genres
                    .Where(g => g.Name != null)
                    .Select(g => g.Name)
                    .ToList();

                TxtGenres.ItemsSource = genres;

                if (genres.Any())
                    TxtGenres.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки жанров: {ex.Message}", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void LoadBookData()
        {
            TxtTitle.Text = _book.Title;
            TxtAuthor.Text = _book.Author;
            TxtYear.Text = _book.YearOfPublication.ToString();
            TxtPrice.Text = _book.Price.ToString();

            if (_book.Genres != null && !string.IsNullOrEmpty(_book.Genres.Name))
            {
                TxtGenres.SelectedItem = _book.Genres.Name;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtTitle.Text))
            {
                MessageBox.Show("Введите название книги!", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TxtAuthor.Text))
            {
                MessageBox.Show("Введите автора книги!", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!int.TryParse(TxtYear.Text, out int year) || year < 0 || year > DateTime.Now.Year)
            {
                MessageBox.Show($"Введите корректный год издания (от 0 до {DateTime.Now.Year})!",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (!decimal.TryParse(TxtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Введите корректную цену (положительное число)!",
                    "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (TxtGenres.SelectedItem == null)
            {
                MessageBox.Show("Выберите жанр книги!", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                string selectedGenreName = TxtGenres.SelectedItem.ToString();
                var genre = _db.Genres.FirstOrDefault(g => g.Name == selectedGenreName);

                if (genre == null)
                {
                    MessageBox.Show("Выбранный жанр не найден в базе данных!", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                if (!_isEditMode)
                {
                    _book.Title = TxtTitle.Text;
                    _book.Author = TxtAuthor.Text;
                    _book.YearOfPublication = year;
                    _book.Price = price;
                    _book.Genres = genre;
                    _book.GenreId = genre.Id;

                    _db.Books.Add(_book);
                }
                else
                {
                    _book.Title = TxtTitle.Text;
                    _book.Author = TxtAuthor.Text;
                    _book.YearOfPublication = year;
                    _book.Price = price;
                    _book.Genres = genre;
                    _book.GenreId = genre.Id;
                }

                _db.SaveChanges();
                DialogResult = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}