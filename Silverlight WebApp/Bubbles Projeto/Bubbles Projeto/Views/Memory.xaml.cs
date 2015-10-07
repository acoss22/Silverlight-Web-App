using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace Bubbles_Projeto
{
    public partial class Memory : Page
    {
        public Memory()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

    }

    public partial class Page1 : Page
    {
        // Use this Random object to choose random icons for the squares
        Random random = new Random();

        // Each of these letters is an interesting icon 
        // in the Webdings font, 
        // and each icon appears twice in this list
        List<string> icons = new List<string>() 
    { 
        "!", "!", "N", "N", ",", ",", "k", "k",
        "b", "b", "v", "v", "w", "w", "z", "z"
    };

    }
}