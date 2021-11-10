using EquiposBackend.Dominio;
using EquiposFrontend.Cliente;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquiposFrontend
{
    public partial class FrmEquipoNuevo : Form
    {
        Accion modo;
        List<PiernaHabil> lstHabilidad;
        List<Posicion> lstPosiciones;
        List<Localidad> lstLocalidades;
        List<TipoCompromisos> lstTipoCompromiso;

        List<Equipo> lstEquipos;
        List<Persona> lstPersonas;
        List<Compromiso> lstCompromisos;
        List<EquipoPersona> lstEquipoPersonas;

        Equipo oEquipo;
        Compromiso oCompromiso;
        EquipoPersona oEP;

        int idEquipo;
        int codigoEP;
        int codigoCompromiso;
        List<Compromiso> lstCompromisosOriginales;
        List<Compromiso> lstCompromisosAgregados;
        List<Compromiso> lstCompromisosEliminados;

        List<EquipoPersona> lstJugadoresOriginales;
        List<EquipoPersona> lstJugadoresAgregados;
        List<EquipoPersona> lstJugadoresEliminados;




        public FrmEquipoNuevo(Accion modo, int idEquipo = 0)
        {
            this.idEquipo = idEquipo;

            this.modo = modo;
            InitializeComponent();
            oEquipo = new Equipo();
            oCompromiso = new Compromiso();
            oEP = new EquipoPersona();
            lstJugadoresOriginales = new List<EquipoPersona>();
            lstJugadoresAgregados = new List<EquipoPersona>();
            lstJugadoresEliminados = new List<EquipoPersona>();

            lstCompromisosOriginales = new List<Compromiso>();
            lstCompromisosAgregados = new List<Compromiso>();
            lstCompromisosEliminados = new List<Compromiso>();

            switch (modo)
            {
                case Accion.Agregar:
                    this.lblTitulo.Text = "Agregar nuevo equipo";
                    this.btnConfirmarAccion.Text = "Agregar Equipo";
                    break;
                case Accion.Modificar:
                    this.lblTitulo.Text = "Modificar el equipo";
                    this.btnConfirmarAccion.Text = "Modificar Equipo";

                    break;
                case Accion.Eliminar:
                    this.lblTitulo.Text = "Dar de Baja al equipo";
                    this.btnConfirmarAccion.Text = "Eliminar Equipo";

                    break;

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private async void FrmEquipoNuevo_Load(object sender, EventArgs e)
        {

            string urlHabilidad = "https://localhost:44381/api/Equipos/piernaHabil";
            var resultadoHabilidad = await ClienteSingleton.GetInstancia().GetAsync(urlHabilidad);
            lstHabilidad = JsonConvert.DeserializeObject<List<PiernaHabil>>(resultadoHabilidad);

            string urlposiciones = "https://localhost:44381/api/Equipos/posiciones";
            var resultado = await ClienteSingleton.GetInstancia().GetAsync(urlposiciones);
            lstPosiciones = JsonConvert.DeserializeObject<List<Posicion>>(resultado);

            cmbPosiciones.DataSource = lstPosiciones;
            cmbPosiciones.DisplayMember = "NombrePosicion";
            cmbPosiciones.ValueMember = "CodPosicion";


            string urllocalidades = "https://localhost:44381/api/Equipos/localidades";
            var resultado2 = await ClienteSingleton.GetInstancia().GetAsync(urllocalidades);
            lstLocalidades = JsonConvert.DeserializeObject<List<Localidad>>(resultado2);

            //cmbLocalidad.Items.AddRange(lstLocalidades.ToArray());
            cmbLocalidad.DataSource = lstLocalidades;
            cmbLocalidad.DisplayMember = "Nombre";
            cmbLocalidad.ValueMember = "IDLocalidad";



            string urltipoCompromisos = "https://localhost:44381/api/Equipos/tipoCompromisos";
            string resultado3 = await ClienteSingleton.GetInstancia().GetAsync(urltipoCompromisos);
            lstTipoCompromiso = JsonConvert.DeserializeObject<List<TipoCompromisos>>(resultado3);

            cmbTipoCompromiso.DataSource = lstTipoCompromiso;
            cmbTipoCompromiso.DisplayMember = "NombreCompromiso";
            cmbTipoCompromiso.ValueMember = "CodCompromiso";

            LoadFormAsync();
        }

        private async void LoadFormAsync()
        {

            string urlEquipos = "https://localhost:44381/api/Equipos/equipos";
            var resultadoEquipos = await ClienteSingleton.GetInstancia().GetAsync(urlEquipos);
            lstEquipos = JsonConvert.DeserializeObject<List<Equipo>>(resultadoEquipos);

            string urlCompromisos = "https://localhost:44381/api/Equipos/compromisos";
            var resultadoCompromisos = await ClienteSingleton.GetInstancia().GetAsync(urlCompromisos);
            lstCompromisos = JsonConvert.DeserializeObject<List<Compromiso>>(resultadoCompromisos);

            string urlpersonas = "https://localhost:44381/api/Equipos/personas";
            string resultado4 = await ClienteSingleton.GetInstancia().GetAsync(urlpersonas);
            lstPersonas = JsonConvert.DeserializeObject<List<Persona>>(resultado4);

            string urlEquipoPersonas = "https://localhost:44381/api/Equipos/equiposPersonas";
            string resultadoEP = await ClienteSingleton.GetInstancia().GetAsync(urlEquipoPersonas);
            lstEquipoPersonas = JsonConvert.DeserializeObject<List<EquipoPersona>>(resultadoEP);


            cmbPosiciones.SelectedIndex = -1;
            cmbLocalidad.SelectedIndex = -1;
            cmbTipoCompromiso.SelectedIndex = -1;

            


            switch (modo)
            {
                case Accion.Agregar:
                    txtNombreEquipo.Text = "";
                    //nro de equipo nuevo
                    if (lstEquipos.Count == 0)
                        oEquipo.CodEquipo = 1;
                    else
                        oEquipo.CodEquipo = lstEquipos.Max(t => t.CodEquipo) + 1;

                    //nro compromiso nuevo
                    if (lstCompromisos.Count == 0)
                        codigoCompromiso = 1;
                    else
                        codigoCompromiso = lstCompromisos.Max(t => t.CodCompromiso) + 1;

                    //fecha alta equipo
                    oEquipo.FechaAlta = DateTime.Today;

                    //codigo Jugador (creo que no hace falta)
                    if (lstEquipoPersonas.Count == 0)
                        codigoEP = 1;
                    else
                        codigoEP = lstEquipoPersonas.Max(t => t.CodEP) + 1;

                    CargarDGVPersonasDisponibles();

                    break;
                case Accion.Modificar:

                    CargarEquipo();

                    break;
                case Accion.Eliminar:
                    //inhabilitamos toda accion
                    dgvPersonasDispo.Enabled = false;
                    cmbPosiciones.Enabled = false;
                    txtCamiseta.Enabled = false;
                    btnAgregarPersona.Enabled = false;
                    dgvPersonasEquipo.Enabled = false;
                    cmbTipoCompromiso.Enabled = false;
                    btnNuevoCompromiso.Enabled = false;
                    dtpCompromiso.Enabled = false;
                    txtCompromiso.Enabled = false;
                    btnAgregarCompromiso.Enabled = false;
                    dgvCompromisos.Enabled = false;
                    btnAgregarLocalidad.Enabled = false;
                    cmbLocalidad.Enabled = false;
                    btnAgregarLocalidad.Enabled = false;
                    txtNombreEquipo.Enabled = false;

                    CargarEquipo();

                    break;
            }
            LimpiarCamposCompromisos();
        }



        private void CargarEquipo()
        {
            oEquipo = lstEquipos.Find(item => item.CodEquipo == idEquipo);            
            CargarDGVPersonasJugando();
            CargarDGVPersonasDisponibles();
            CargarDGVCompromisos();
            cmbLocalidad.SelectedValue = oEquipo.CodLocalidad;
            txtNombreEquipo.Text = oEquipo.Nombre;
            lstCompromisosOriginales.AddRange(oEquipo.Compromisos);
            lstJugadoresOriginales.AddRange(oEquipo.Jugadores);
        }

        private void CargarDGVPersonasDisponibles()
        {
           //lista con todas las personas registradas
            List<Persona> lstPersonasDisponibles = new List<Persona>();
            lstPersonasDisponibles.AddRange(lstPersonas);
            
            //quitamos las personas que estan en el equipo
            if (oEquipo.Jugadores.Count != 0)            
                foreach (EquipoPersona oEPRemov in oEquipo.Jugadores)               
                    lstPersonasDisponibles.RemoveAll(item => item.CodPersona == oEPRemov.Persona.CodPersona);
            
            //quitamos personas cuyo registro este como dada de baja
            lstPersonasDisponibles.RemoveAll(item => item.FechaBaja.HasValue);


            dgvPersonasDispo.Rows.Clear();

            //si quedan personas disponibles, cargarlas en el dgv
            if (lstPersonasDisponibles.Count != 0)
                foreach (Persona oPersona in lstPersonasDisponibles)
                {
                    dgvPersonasDispo.Rows.Add(new object[] {
                    oPersona.CodPersona,
                    oPersona.Apellido,
                    oPersona.Nombre,
                    lstHabilidad.Find(item => oPersona.PiernaHabil == item.codPierna).Habilidad,
                    oPersona.Peso,
                    oPersona.Estatura,
                    oPersona.FechaNac.ToString("dd/MM/yyyy")
                    });
                }
            dgvPersonasDispo.Sort(dgvPersonasDispo.Columns[1], ListSortDirection.Ascending);
        }


        private void CargarDGVPersonasJugando()
        {
            dgvPersonasEquipo.Rows.Clear();
            //quitamos los jugadores inactivos del equipo
            List<EquipoPersona> lstJugadoresActivos = new List<EquipoPersona>();
            lstJugadoresActivos.Clear();
            lstJugadoresActivos.AddRange(oEquipo.Jugadores);
            lstJugadoresActivos.RemoveAll(item => item.FechaBaja.HasValue);

            //si el equipo no tiene jugadores, no hace nada, sino los carga
            if (lstJugadoresActivos != null)
            {
                foreach (EquipoPersona oEPActivo in lstJugadoresActivos)
                {
                    //este if creo que esta de mas
                    //if (!oEPActivo.FechaAlta.ToString("dd/MM/yyyy").Equals("01/01/0001"))
                    //    oEPActivo.FechaAlta.ToString("dd/MM/yyyy");
                    //else
                    //    oEPActivo.FechaAlta = DateTime.Today;

                    dgvPersonasEquipo.Rows.Add(new object[] {
                    oEPActivo.Persona.CodPersona,
                    oEPActivo.Persona.Apellido,
                    lstPosiciones.Find(item => oEPActivo.CodPosicion == item.codPosicion).NombrePosicion,
                    lstHabilidad.Find(item => oEPActivo.Persona.PiernaHabil == item.codPierna).Habilidad,
                    oEPActivo.Camiseta,
                    oEPActivo.FechaAlta.ToString("dd/MM/yyyy"),
                    "Quitar" });
                }
                dgvPersonasDispo.Sort(dgvPersonasDispo.Columns[1], ListSortDirection.Ascending);
            }
                
        }

        private void CargarDGVCompromisos()
        {
            //quitamos los compromisos dados de baja
            List<Compromiso> lstCompromisosActivos = new List<Compromiso>();
            lstCompromisosActivos.AddRange(oEquipo.Compromisos);
            lstCompromisosActivos.RemoveAll(item => item.FechaBaja.HasValue);

            dgvCompromisos.Rows.Clear();
            //si quedan compromisos, los listamos
            if (oEquipo.Compromisos != null)
            {
                foreach (Compromiso oCompromiso in lstCompromisosActivos)
                {
                    dgvCompromisos.Rows.Add(new object[] {
                        oCompromiso.CodCompromiso,
                        oEquipo.CodEquipo,
                        lstTipoCompromiso.Find(item => oCompromiso.TipoCompromiso.CodCompromiso == item.CodCompromiso).NombreCompromiso,
                        oCompromiso.ComentariosCompromiso,
                        oCompromiso.FechaCompromiso.ToString("dd/MM/yyyy"), // ToShortDateString(),
                        "Quitar"});
                }
                dgvCompromisos.Sort(dgvCompromisos.Columns[4], ListSortDirection.Ascending);
            }

        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            if (dgvPersonasDispo.SelectedRows.Count == 1)
            {
                //esta validacion no hace falta porque quitamos las personas del DGV de los disponibles
                //if (ExisteJugadorEnEquipo(Convert.ToInt32(dgvPersonasDispo.CurrentRow.Cells["idPersona"].Value.ToString())))
                //{
                //    MessageBox.Show("Jugador ya agregado al Equipo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}



                // asignamos la persona al equipo desde la lista de personas global
                oEP = new EquipoPersona();
                oEP.Persona = lstPersonas.Find(item => item.CodPersona == Convert.ToInt32(dgvPersonasDispo.CurrentRow.Cells["idPersona"].Value.ToString()));
                
                //Agregamos la posicion de la persona en el equipo
                if(cmbPosiciones.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor seleccione una posición para jugar en el equipo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                Posicion oPosi = (Posicion)cmbPosiciones.SelectedItem;
                oEP.CodPosicion = oPosi.codPosicion;

                //agregamos los datos de la camiseta
                if (txtCamiseta.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Por favor ingrese datos de la camiseta.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                oEP.Camiseta = txtCamiseta.Text;

                //completamos datos restantes. CodEP creo que es innecesario.
                oEP.CodEP = codigoEP++;
                oEP.FechaAlta = DateTime.Today;


                switch (modo)
                {
                    case Accion.Agregar: // cuando es Alta de nuevo equipo, no revisamos que jugador agregamos.
                        oEquipo.AgregarJugador(oEP);
                        CargarDGVPersonasJugando();
                        CargarDGVPersonasDisponibles();
                        LimpiarCamposJugadorNuevo();

                        break;
                    case Accion.Modificar:// cuando es Modificacion, Primero miramos si hay jugadores... si no, lo agregamos a una nueva lista.
                                          // Si hay jugadores, agregamos al jugador a una lista nueva para luego iterarla,
                                          // pero confirmamos que no haya estado ya cargado en la lista
                        oEP.CodEquipo = oEquipo.CodEquipo;
                        int codJugadorAgregado = Convert.ToInt32(dgvPersonasDispo.CurrentRow.Cells["idPersona"].Value.ToString());
                        if (lstJugadoresAgregados.Count == 0)
                            lstJugadoresAgregados.Add(oEP);
                        else
                        {
                            int indiceLstJugadoresAgregados = lstJugadoresAgregados.FindIndex(item => item.Persona.CodPersona == codJugadorAgregado);
                            if (indiceLstJugadoresAgregados == -1)
                                lstJugadoresAgregados.Add(oEP);
                            else
                                lstJugadoresAgregados[indiceLstJugadoresAgregados] = oEP;

                        }
                        //finalmente agregamos al jugador al equipo, para mantener la consistencia de los objetos.
                        oEquipo.AgregarJugador(oEP);

                        CargarDGVPersonasJugando();
                        CargarDGVPersonasDisponibles();
                        LimpiarCamposJugadorNuevo();
                        break;

                }                               
            }                
        }

        private void LimpiarCamposJugadorNuevo()
        {
            txtCamiseta.Text = "";
            cmbPosiciones.SelectedIndex = -1;
        }

        //private bool ExisteJugadorEnEquipo(int idJugador)
        //{
        //    foreach (DataGridViewRow fila in dgvPersonasEquipo.Rows)
        //    {
        //        if (fila.Cells["idJugador"].Value.Equals(idJugador))
        //            return true;
        //    }
        //    return false;
        //}

        private void btnAgregarCompromiso_Click(object sender, EventArgs e)
        {
            if (txtCompromiso.Text.Trim().Equals(""))
            {
                MessageBox.Show("Por favor ingrese detalles del compromiso.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(dtpCompromiso.Value.Date == DateTime.Today)
            {
                if (MessageBox.Show("Esta seguro que desea agregar un compromiso hoy?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }

            }
            if (dtpCompromiso.Value.Date < DateTime.Today)
            {
                if (MessageBox.Show("Esta seguro que desea agregar un compromiso en una fecha pasada?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }

            }


            if (cmbTipoCompromiso.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor elija un tipo de compromiso.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TipoCompromisos oTC = new TipoCompromisos();
            oCompromiso = new Compromiso();
            oCompromiso.CodCompromiso = codigoCompromiso++;
            oCompromiso.CodEquipo = oEquipo.CodEquipo;
            oCompromiso.ComentariosCompromiso = txtCompromiso.Text;
            oCompromiso.FechaCompromiso = dtpCompromiso.Value;
            oCompromiso.FechaAlta = DateTime.Today;
            oTC = (TipoCompromisos)cmbTipoCompromiso.SelectedItem;
            oCompromiso.TipoCompromiso = oTC;
            oEquipo.AgregarCompromiso(oCompromiso);
            CargarDGVCompromisos();



            switch (modo)
            {
                case Accion.Agregar:
                                        

                    break;
                case Accion.Modificar:
                    
                    lstCompromisosAgregados.Add(oCompromiso);
                    
                    break;
                
            }

            LimpiarCamposCompromisos();


        }

        private void LimpiarCamposCompromisos()
        {
            cmbTipoCompromiso.SelectedIndex = -1;
            txtCompromiso.Text = "";
            dtpCompromiso.Value = DateTime.Today;
        }

        private async void btnConfirmarAccion_Click(object sender, EventArgs e)
        {
            if (txtNombreEquipo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Por favor elija un nombre para el equipo.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                oEquipo.Nombre = txtNombreEquipo.Text;
            }

            if(dgvPersonasEquipo.Rows.Count == 0)
            {
                if (MessageBox.Show("Esta seguro que desea tener un equipo sin jugadores?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }

            if(dgvCompromisos.Rows.Count == 0)
            {
                if (MessageBox.Show("Esta seguro que desea tener un equipo sin compromisos?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
            }

            if(cmbLocalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor elija una localidad para el equipo.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                oEquipo.CodLocalidad = (int)cmbLocalidad.SelectedValue;
            }

            string datosJSONEquipoFull = JsonConvert.SerializeObject(oEquipo);
            switch (modo)
            {
                case Accion.Agregar:
                    try
                    {
                        string urlEquipo = "https://localhost:44381/api/Equipos/crearEquipoFull";
                        string resultadoEquipo = await ClienteSingleton.GetInstancia().PostAsync(urlEquipo, datosJSONEquipoFull);
                        MessageBox.Show(resultadoEquipo, "Resultado", MessageBoxButtons.OK);
                        dgvPersonasEquipo.Rows.Clear();
                        txtNombreEquipo.Text = string.Empty;
                        cmbLocalidad.SelectedIndex = -1;
                        dgvCompromisos.Rows.Clear();

                        oEquipo = new Equipo();


                    }
                    catch
                    {
                        MessageBox.Show("Error al Registrar", "Resultado", MessageBoxButtons.OK);
                        return;
                    }
                    break;
                case Accion.Modificar:
                                        
                    string urlModificarEquipo = "https://localhost:44381/api/Equipos/editarEquipo";
                    string resultadoModificarEquipo = await ClienteSingleton.GetInstancia().PutAsync(urlModificarEquipo, datosJSONEquipoFull);
                    MessageBox.Show(resultadoModificarEquipo, "Resultado", MessageBoxButtons.OK);

                    if (lstJugadoresAgregados.Count != 0)
                        foreach (EquipoPersona oEPagregados in lstJugadoresAgregados)
                        {
                            //hacer un insert para cada oEP
                            string datosJsonNuevosJugadores = JsonConvert.SerializeObject(oEPagregados);
                            string url = "https://localhost:44381/api/Equipos/insertarEquipoPersona";
                            string resultado = await ClienteSingleton.GetInstancia().PostAsync(url, datosJsonNuevosJugadores);
                            resultado += oEPagregados.Persona.Apellido;
                            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK);
                        }

                    if (lstJugadoresEliminados.Count != 0)
                        foreach(EquipoPersona oEPbajas in lstJugadoresEliminados)
                        {
                            //hacer baja para cada oEPbajas
                            string url = "https://localhost:44381/api/Equipos/jugador/" + oEPbajas.CodEP;
                            string resultado = await ClienteSingleton.GetInstancia().DeleteAsync(url);
                            resultado += oEPbajas.Persona.Apellido;
                            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK);

                        }
                    if(lstCompromisosAgregados.Count != 0)                    
                        foreach(Compromiso oCompAdd in lstCompromisosAgregados)
                        {
                            string datosJsonNuevosCompromisos = JsonConvert.SerializeObject(oCompAdd);
                            string url = "https://localhost:44381/api/Equipos/insertarCompromiso";
                            string resultado = await ClienteSingleton.GetInstancia().PostAsync(url, datosJsonNuevosCompromisos);

                           // MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK);
                        }
                    if (lstCompromisosEliminados.Count != 0)
                        foreach (Compromiso oComprElim in lstCompromisosEliminados)
                        {
                            //hacer baja para cada Compromiso
                            string url = "https://localhost:44381/api/Equipos/compromiso/" + oComprElim.CodCompromiso;
                            string resultado = await ClienteSingleton.GetInstancia().DeleteAsync(url);
                            
                           // MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK);

                        }

                    break;
                case Accion.Eliminar:
                    if (MessageBox.Show("Esta seguro que desea eliminar el equipo? Va a dar de baja sus compromisos y jugadores.",
                            "Atención!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        return;
                    }
                    try
                    {
                        string url = "https://localhost:44381/api/Equipos/equipo/" + oEquipo.CodEquipo;
                        string resultado = await ClienteSingleton.GetInstancia().DeleteAsync(url);
                        MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK);
                    }
                    catch
                    {
                        MessageBox.Show("Error en el cliente al dar de baja!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    this.Close();
                    break;
            }
            LoadFormAsync();
            
            LimpiarCamposJugadorNuevo();
            txtNombreEquipo.Text = "";
            cmbLocalidad.SelectedIndex = -1;
            CargarDGVPersonasDisponibles();
        }

        private void dgvPersonasEquipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (modo)
            {
                case Accion.Agregar: //Cuando es Alta de equipo, quitamos los jugadores sin problema
                    if (dgvPersonasEquipo.CurrentCell.ColumnIndex == 6)
                    {
                        oEquipo.QuitarJugador(Convert.ToInt32(dgvPersonasEquipo.CurrentRow.Cells["idJugador"].Value.ToString()));
                        dgvPersonasEquipo.Rows.Remove(dgvPersonasEquipo.CurrentRow);
                        CargarDGVPersonasDisponibles();
                    }

                    break;
                case Accion.Modificar: //Cuando es modificacion de equipo, primero pedimos confirmacion
                    if (dgvPersonasEquipo.CurrentCell.ColumnIndex == 6)
                    {
                        if (MessageBox.Show("Esta seguro que desea quitar al jugador del equipo?",
                            "Atención!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            return;
                        }
                        //Tomamos el id del jugador que eliminamos y lo comparamos con la lista de jugadores originales que importamos
                        //cuando trajimos el equipo.
                        //Si el jugador esta en la lista original, lo agregamos a una lista para iterar los jugadores q daremos de baja;
                        //Sino, lo eliminamos de los jugadores que estan en la lista para insertar nuevos jugadores al equipo.
                        int codJugadorEliminado = Convert.ToInt32(dgvPersonasEquipo.CurrentRow.Cells["idJugador"].Value.ToString());
                        if (lstJugadoresOriginales.Exists(item => codJugadorEliminado == item.Persona.CodPersona))
                            lstJugadoresEliminados.Add(lstJugadoresOriginales.Find(item => codJugadorEliminado == item.Persona.CodPersona));
                        else
                            lstJugadoresAgregados.RemoveAt(lstJugadoresAgregados.FindIndex(item => codJugadorEliminado == item.Persona.CodPersona));
                        
                        oEquipo.QuitarJugador(codJugadorEliminado);
                        dgvPersonasEquipo.Rows.Remove(dgvPersonasEquipo.CurrentRow);
                        CargarDGVPersonasDisponibles();
                    }
                    break;
            }

        }

        private void dgvCompromisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            switch (modo)
            {
                case Accion.Agregar:
                    if (dgvCompromisos.CurrentCell.ColumnIndex == 5)
                    {
                        oEquipo.QuitarCompromiso(Convert.ToInt32(dgvCompromisos.CurrentRow.Cells["idCompromiso"].Value.ToString()));
                        dgvCompromisos.Rows.Remove(dgvCompromisos.CurrentRow);
                    }

                    break;
                case Accion.Modificar:

                    if (dgvCompromisos.CurrentCell.ColumnIndex == 5)
                    {
                        //confirmar que queremos eliminar el compromiso
                        if (MessageBox.Show("Esta seguro que desea quitar el compromiso del equipo?",
                            "Atención!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.No)
                        {
                            return;
                        }

                        int codCompromisoEliminado = Convert.ToInt32(dgvCompromisos.CurrentRow.Cells["idCompromiso"].Value.ToString());
                        if (lstCompromisosOriginales.Exists(item => codCompromisoEliminado == item.CodCompromiso))
                            lstCompromisosEliminados.Add(lstCompromisosOriginales.Find(item => codCompromisoEliminado == item.CodCompromiso));
                        else
                            lstCompromisosAgregados.RemoveAt(lstCompromisosAgregados.FindIndex(item => codCompromisoEliminado == item.CodCompromiso));

                        oEquipo.QuitarCompromiso(Convert.ToInt32(dgvCompromisos.CurrentRow.Cells["idCompromiso"].Value.ToString()));
                        dgvCompromisos.Rows.Remove(dgvCompromisos.CurrentRow);
                    }

                    
                    //chequear que el compromiso que eliminamos sea uno original del equipo
                    //si es uno de los originales entonces agrergar el compromiso eliminado
                    //a una lista para iterar y darlos de baja
                    //si no es original, entonces darlo de baja de la lista de alta

                    break;                
            }
            
        }


        private async void btnAgregarLocalidad_Click(object sender, EventArgs e)
        {
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.localidades, Accion.Agregar);
            this.Opacity = 0.3;
            frmTablasSoporte.ShowDialog();
            this.Opacity = 1;
            string urllocalidades = "https://localhost:44381/api/Equipos/localidades";
            var resultado2 = await ClienteSingleton.GetInstancia().GetAsync(urllocalidades);
            lstLocalidades = JsonConvert.DeserializeObject<List<Localidad>>(resultado2);

            //cmbLocalidad.Items.AddRange(lstLocalidades.ToArray());
            cmbLocalidad.DataSource = lstLocalidades;
            cmbLocalidad.DisplayMember = "Nombre";
            cmbLocalidad.ValueMember = "IDLocalidad";
            cmbLocalidad.SelectedIndex = -1;

        }

        private async void btnNuevoCompromiso_Click(object sender, EventArgs e)
        {
            FrmTablasSoporte frmTablasSoporte = new FrmTablasSoporte(TablasSoporte.tipoCompromisos, Accion.Modificar);
            this.Opacity = 0.3;
            frmTablasSoporte.ShowDialog();
            this.Opacity = 1;
            string urltipoCompromisos = "https://localhost:44381/api/Equipos/tipoCompromisos";
            string resultado3 = await ClienteSingleton.GetInstancia().GetAsync(urltipoCompromisos);
            lstTipoCompromiso = JsonConvert.DeserializeObject<List<TipoCompromisos>>(resultado3);

            cmbTipoCompromiso.DataSource = lstTipoCompromiso;
            cmbTipoCompromiso.DisplayMember = "NombreCompromiso";
            cmbTipoCompromiso.ValueMember = "CodCompromiso";
            cmbTipoCompromiso.SelectedIndex = -1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}

