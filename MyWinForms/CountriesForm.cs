using MyWinForms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForms
{
    public partial class CountriesForm : Form
    {
        private readonly AppEFContext _context = new AppEFContext();
        private int currentPage = 1;
        private int pageSize = 3;
        private int totalPages = 0; 
        public CountriesForm()
        {
            InitializeComponent();
        }
        private void LoadList()
        {
            dgvCountries.Rows.Clear();
            var query = _context.Countries.AsQueryable();
            var countries = query
                .Skip((currentPage - 1) * pageSize)  
                .Take(pageSize) 
                .ToList();

            foreach (var country in countries)
            {
                object[] row =
                {
                    country.Id,
                    country.Name,
                    Image.FromFile(Path.Combine("image", country.FlagImage))
                };
                dgvCountries.Rows.Add(row);
            }
            int count = query.Count();
            totalPages = (int)Math.Ceiling(count / (double)pageSize);
            //btnNext.Enabled = currentPage == totalPages ? false : true;
            //btnPrev.Enabled = currentPage == 1 ? false : true;
        }


    }
}
