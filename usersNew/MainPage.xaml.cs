﻿using static System.Runtime.InteropServices.JavaScript.JSType;

namespace usersNew
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public List<Student> list = new List<Student>();
        public int ids = 0;
        public List<string> listColors = new List<string>() { "#3F56EC", "#EC7E3F", "#EC3F76", "#3F95EC", "#ECBB3F" };

        public async void agrega_ClickedAsync(object sender, EventArgs e)
        {
            ids++;
            Random random = new();
            int randomIndex = random.Next(0, listColors.Count);
            list.Add(new Student(ids, name.Text, paterno.Text, materno.Text, unity.SelectedItem.ToString(), listColors[randomIndex]));
            await DisplayAlert("Correcto", "Estudiante agregado", "Ok");
            name.Text = "";
            paterno.Text = "";
            materno.Text = "";
            unity.SelectedIndex = 0;
        }

        async void Delete_Clicked(object sender, EventArgs e)
        {
            string id = await DisplayPromptAsync("Eliminae","Ingresa el ID a eliminar");
            try
            {
                bool deleted = false;
                foreach (Student std in list)
                {
                    if (Convert.ToInt32(std.id) == Convert.ToInt32(id))
                    {
                        deleted = true;
                        list.Remove(std);
                        break;
                    }
                }
                if (deleted)
                {
                    await DisplayAlert("Correcto", "Estudiante eliminado", "Ok");
                }
                else
                {
                    await DisplayAlert("Error", "Estudiante no encontrado", "Ok");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                await DisplayAlert("Error", "Estudiante no encontrado", "Ok");
            }
        }

        private async void show_Clicked(object sender, EventArgs e)
        {
            FlowContentAll otraPagina = new FlowContentAll(list);

            await Navigation.PushAsync(otraPagina);
        }
    }
}