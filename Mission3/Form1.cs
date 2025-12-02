using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mission3 // Vérifie que c'est bien le nom de ton projet
{
    public partial class Form1 : Form
    {
        // --- 1. CONNEXION BDD ---
        private gsbrapports2016Entities monModele = new gsbrapports2016Entities();

        public Form1()
        {
            InitializeComponent();
        }

        // --- 2. CHARGEMENT DE LA FENÊTRE ---
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                var lesDepartements = monModele.medecin
                                        .Select(m => m.departement)
                                        .Distinct()
                                        .OrderBy(d => d)
                                        .ToList();
                cboDepartement.DataSource = lesDepartements;
                cboDepartement.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        // --- 3. BOUTON RECHERCHER ---
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string nomSaisi = txtNom.Text;
            var requete = monModele.medecin.AsQueryable();

            if (!string.IsNullOrEmpty(nomSaisi))
            {
                requete = requete.Where(m => m.nom.StartsWith(nomSaisi));
            }

            if (cboDepartement.SelectedIndex != -1)
            {
                int deptChoisi = Convert.ToInt32(cboDepartement.SelectedItem);
                requete = requete.Where(m => m.departement == deptChoisi);
            }

            dgvMedecins.DataSource = requete.ToList();

            // Masquer les colonnes inutiles si elles existent
            if (dgvMedecins.Columns["rapport"] != null) dgvMedecins.Columns["rapport"].Visible = false;
            if (dgvMedecins.Columns["departement1"] != null) dgvMedecins.Columns["departement1"].Visible = false;
        }

        // --- 4. BOUTON SUPPRIMER ---
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvMedecins.SelectedRows.Count > 0)
            {
                var medecinSelectionne = (medecin)dgvMedecins.SelectedRows[0].DataBoundItem;

                var confirmation = MessageBox.Show($"Voulez-vous vraiment supprimer {medecinSelectionne.nom} ?",
                                                   "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmation == DialogResult.Yes)
                {
                    try
                    {
                        monModele.medecin.Remove(medecinSelectionne);
                        monModele.SaveChanges();
                        MessageBox.Show("Supprimé avec succès.");

                        // On simule un clic sur rechercher pour rafraîchir la liste
                        btnRechercher_Click(sender, e);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Impossible de supprimer ce médecin (il a des rapports liés).", "Erreur");

                        // Astuce pour annuler la suppression en mémoire si ça a planté
                        // (On recharge l'état initial des objets modifiés)
                        var entitesModifiees = monModele.ChangeTracker.Entries()
                            .Where(x => x.State != System.Data.Entity.EntityState.Unchanged).ToList();
                        foreach (var entry in entitesModifiees) entry.Reload();
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne.");
            }
        }
    }
}