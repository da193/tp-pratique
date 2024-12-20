using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tp_pratique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ChargerEtudiants();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectString = "Server=localhost;User ID=roots;Password='';Database=tp-group;AllowZeroDatetime=True;";
            try
            {
                using (MySqlConnection connect = new MySqlConnection(connectString))
                {
                    connect.Open();
                    MessageBox.Show("connexion de la BD avec success", "sucess",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreure de connexion a la DB" +
                    ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string texteEntre = nom.Text; // Remplace "txtNom" par le nom de ton TextBox
            //MessageBox.Show(texteEntre);
        }

        private void prenom_TextChanged(object sender, EventArgs e)
        {
            string texteEntre = prenom.Text;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            string texteEntre = email.Text;
        }


        private void naissance_TextChanged(object sender, EventArgs e)
        {
            string nais = naissance.Text;
        }

        private void telephne_TextChanged(object sender, EventArgs e)
        {
            string tel = telephone.Text;
        }

        private void gender_CheckedChanged(object sender, EventArgs e)
        {
            string sex = gender.Text;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            string name = nom.Text;
            string fName = prenom.Text;
            string birth = naissance.Text;
            string mail = email.Text;
            string phone = telephone.Text;
            string sex = gender.Text;
            //MessageBox.Show("Vous avez entré : " + name + fName + birth + mail + phone + sex);

            string connectString = "Server=localhost;User ID=roots;Password='';Database=tp-group;AllowZeroDatetime=True;";
            using (MySqlConnection connect = new MySqlConnection(connectString))
            {
                connect.Open();
                //string query = "INSERT INTO etudiant (nom, prenom,naissance,telephone,gender) VALUES (@Name, @fname,@b,@phone,@sex)";
                string query = "INSERT INTO etudiant (nom, prenom,naissance,email,telephone,gender) VALUES (@Name, @fname,@b,@mal,@phone,@sex)";
                using (var cmd = new MySqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@fname", fName);
                    cmd.Parameters.AddWithValue("@b", birth);
                    cmd.Parameters.AddWithValue("@mal", mail);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@sex", sex);
                    cmd.ExecuteNonQuery();
                }
            }
            ChargerEtudiants();
        }

        //*** Data Grid View for the view of all the operations carried out ********
        private void ListesDesEtudiants_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ListesDesEtudiants.Columns["Update"].Index)
            {
                int studentId = Convert.ToInt32(ListesDesEtudiants.Rows[e.RowIndex].Cells["Id"].Value); // Assurez-vous que "Id" est le nom de votre colonne d'ID
                                                                                                        // Appelez votre méthode de mise à jour ici
                UpdateStudent(studentId);
            }
            if (e.ColumnIndex == ListesDesEtudiants.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Récupérer l'ID de l'étudiant à supprimer
                int studentId = Convert.ToInt32(ListesDesEtudiants.Rows[e.RowIndex].Cells["Id"].Value);

                // Demander une confirmation avant de supprimer
                var result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet étudiant ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteStudent(studentId);
                }
            }

        }
        private void UpdateStudent(int id)
        {
            string connectString = "Server=localhost;User ID=roots;Password='';Database=tp-group;AllowZeroDatetime=True;";
            using (MySqlConnection connect = new MySqlConnection(connectString))
            {
                try
                {
                    connect.Open();
                    string query = "SELECT nom,prenom, naissance, email, telephone, gender  FROM etudiant WHERE Id = @Id"; // Remplacez par votre requête SQL

                    MySqlCommand command = new MySqlCommand(query, connect);
                    command.Parameters.AddWithValue("@Id", id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Supposons que vous ayez des champs de texte pour le nom et l'email
                            nom.Text = reader["nom"].ToString();
                            prenom.Text = reader["prenom"].ToString();
                            naissance.Text = reader["naissance"].ToString();
                            email.Text = reader["email"].ToString();
                            telephone.Text = reader["telephone"].ToString();
                            gender.Text = reader["gender"].ToString();
                        }                     

                        else 
                        {
                            MessageBox.Show("Aucun étudiant trouvé avec cet ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la récupération des données : {ex.Message}");
                }
            }
        }


        private void ChargerEtudiants()
        {
            string connectString = "Server=localhost;User ID=roots;Password='';Database=tp-group;AllowZeroDatetime=True;";

            using (MySqlConnection connection = new MySqlConnection(connectString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM etudiant";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        // Ajout d'une colonne pour le bouton Update
                        dataTable.Columns.Add("Update", typeof(string));
                        foreach (DataRow row in dataTable.Rows)
                        {
                            row["Update"] = "Update"; // Texte du bouton
                        }
                        // Ajout d'une colonne pour le bouton Delete
                        dataTable.Columns.Add("Delete", typeof(string));


                        foreach (DataRow row in dataTable.Rows)
                        {
                            row["Delete"] = "Delete"; // Texte du bouton
                        }
                        ListesDesEtudiants.DataSource = dataTable;

                        // Configure le DataGridView pour afficher le bouton
                        ListesDesEtudiants.Columns["Update"].DisplayIndex = dataTable.Columns.Count - 1; // Dernière colonne
                        ListesDesEtudiants.Columns["Delete"].DisplayIndex = dataTable.Columns.Count - 1; // Dernière colonne
                        ListesDesEtudiants.Columns["Update"].Width = 100; // Largeur du bouton
                        ListesDesEtudiants.Columns["Delete"].Width = 100; // Largeur du bouton
                        ListesDesEtudiants.Columns["Update"].ReadOnly = true; // Rendre la colonne en lecture seule
                        ListesDesEtudiants.Columns["Delete"].ReadOnly = true; // Rendre la colonne en lecture seule

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void DeleteStudent(int id)
        {
            string connectString = "Server=localhost;User ID=roots;Password='';Database=tp-group;AllowZeroDatetime=True;";
            using (MySqlConnection connect = new MySqlConnection(connectString))
            {
                try
                {
                    string query = "DELETE FROM etudiant WHERE Id = @Id"; // Assurez-vous que "Id" est le nom de votre colonne d'ID
                    using (MySqlCommand command = new MySqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        connect.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("L'étudiant a été supprimé avec succès !");
                            ChargerEtudiants(); // Recharger la liste des étudiants
                        }
                        else
                        {
                            MessageBox.Show("Aucune suppression effectuée.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur: " + ex.Message);
                }
                finally
                {
                    connect.Close();
                }
            }
          
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            

            ChargerEtudiants();
        }

        //private void UpdateButton(object sender, EventArgs e)
        //{

        //}
    }
    
}
