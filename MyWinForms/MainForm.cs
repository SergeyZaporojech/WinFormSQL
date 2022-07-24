using MyWinForms.Data;
using System.Drawing.Imaging;

namespace MyWinForms
{
    public partial class MainForm : Form
    {
        private readonly AppEFContext _context = new AppEFContext();
        private int currentPage = 1;//поточна сторінка
        private int pageSize = 2;//кількість записів які показуємо
        private int totalPages = 0; //Кільекість сторінок, які можна відображати
        

        public MainForm()
        {
            InitializeComponent();
            LoadList();
        }
        private void LoadList()
        {
            dgvUsers.Rows.Clear();

            //var users = _context.Users.ToList();
            var query = _context.Users.AsQueryable();//робимо sql запит
            var users = query
                .Skip((currentPage - 1) * pageSize) //Кількість запитів які прорускаємо 
                .Take(pageSize)//Кількість записів які виводимо з БД 
                .ToList();


            foreach (var user in users)
            {
                object[] row = { user.Id, Image.FromFile(Path.Combine("image", user.Photo)),
                    user.Name, user.Email, user.Phone };
                dgvUsers.Rows.Add(row);
            }
            int count = query.Count();
            totalPages = (int)Math.Ceiling(totalPages / (double)pageSize);

            //if (currentPage == totalPages)
            //{
            //    btnNext.Enabled = false;
            //}
            //else 
            //if (currentPage == 1)
            //{
            //    btnPrev.Enabled = false;
            //}
            //else btnPrev.Enabled = true;

            btnNext.Enabled = currentPage == totalPages ? false : true;
            btnPrev.Enabled = currentPage == 1  ? false : true;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUserForm dlg = new AddUserForm();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string dir = "image";
                if (!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                Bitmap bitmap = new Bitmap(dlg.ImagePhoto);
                string imageName = Path.GetRandomFileName() + ".jpg";
                bitmap.Save(Path.Combine(dir,imageName), ImageFormat.Jpeg); // формуємо файл зображення у папці та з назвою

                AppUser user = new AppUser()
                {
                    Name = dlg.Pib,
                    Email = dlg.Email,
                    Phone = dlg.Phone,
                    Photo = imageName
                };
                _context.Users.Add(user);
                _context.SaveChanges();
                LoadList();   
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvUsers.SelectedRows)
            {
                dgvUsers.Rows.Remove(row);
            }


            //var item = dgvUsers.SelectedRows;

            //AppUser user = new AppUser()
            //{
            //    Photo = item[1].ToString(),
            //    Name = item[2].ToString(),
            //    Email = item[3].ToString(),
            //    Phone = item[4].ToString()
            //};

            //_context.Remove(user);
            //_context.SaveChanges();
            //LoadList();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadList();
        }



        private void btnPrev_Click(object sender, EventArgs e)
        {
            currentPage--;
            LoadList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectRow = dgvUsers.GetCellCount(DataGridViewElementStates.Selected);
            if (selectRow > 0)
            {
                if (dgvUsers.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cell are selected");
                }
                else
                {
                    if (selectRow > 1)
                    {
                        MessageBox.Show("Оберіть один рядок");
                        return;
                    }
                    var index = dgvUsers.SelectedCells[0].RowIndex;
                    int id = (int)dgvUsers.Rows[index].Cells[0].Value;
                    var user = _context.Users.SingleOrDefault(x => x.Id == id);
                    if (user != null)
                    {
                        string userImage = Path.Combine("image", user.Photo);
                        EditUserForm dlg = new EditUserForm();
                        dlg.Pib = user.Name;
                        dlg.ImagePhoto = userImage;
                        dlg.Email = user.Email;
                        dlg.Phone = user.Phone;
                        if (dlg.ShowDialog() == DialogResult.OK)
                        {
                            if (dlg.ImagePhoto!= userImage)
                            {
                                Bitmap bitmap = new Bitmap(dlg.ImagePhoto);
                                string imageName = Path.GetRandomFileName() + ".jpg";
                                bitmap.Save(Path.Combine("Image" ,  imageName), ImageFormat.Jpeg);
                                user.Photo = imageName;
                            }
                            user.Email= dlg.Email;
                            user.Phone= dlg.Phone; 
                            user.Name= dlg.Pib;
                            
                            //_context.Users.Update(user); // два варіанта як зробити
                            _context.SaveChanges();
                        }
                    
                    }
                    MessageBox.Show("Id = " + id);
                }
            }
            else
            {
                MessageBox.Show("Оберіть один рядок який потрібно змінити ");
            }

        }
    }
}
