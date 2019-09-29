using ECHO_API.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECHO_API.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        /*
       This command aply reverse engineer from the database with the especific tables, 
       for update changes from the database jus re aply de reverse engineer but all your own changes will be lost  
       That parameters can be changed, according with your database config
       This command runs with PMC 

       Scaffold-DbContext "Server=RAFA-SEQUEIRA;Database=bd;Trusted_Connection=True;" -Force Microsoft.EntityFrameworkCore.SqlServer -ContextDir Persistence/Contexts -OutputDir Domain/Models -Tables AccesosAgenda, AcompannantePaciente, Admision, AgendaConvenioDetalle, AgendaConvenios, AgendaMedicos, Alergias, AlergiasPaciente, Cantones, CasoConsulta, CategoriaExamenes, ConsultaMedica, ControlNotas, ControlSignos, CosentimientoInformado, DatosPadres, Distritos, EmpresaConvenios, EntidadJuridica, Especialidades, EstadoCivil, ExamenFisico, FacturasDetalles, FacturasEncabezado, HistoriaClinica, HistorialMedico, Internamientos, MedicoEspecialidad, Medicos, MotivosConsulta, MotivosConsultaAgenda, MotivosConsultaEspecialidad, Nacionalidades, NotaOperatoria, NotasEnfermeria, NotasEvolucion, Ocupaciones, Pacientes, Perfil_Detalle_Acceso_Agenda, PersonalInternamiento, PlanCitas, PlanesEvolucion, Provincias, RecetasMedicas, SolicitudExamenes, TipoAlergias, TipoIdentificacion, TiposExamenes, TomaSignos, Usuarios, FuncionPersonalInternamiento
       */
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<CostarricensesBusqueda> CostarricensesBusqueda { get; set; }
        // Just created for search people (just ticos)

        public virtual DbSet<AccesosAgenda> AccesosAgenda { get; set; }
        public virtual DbSet<AcompannantePaciente> AcompannantePaciente { get; set; }
        public virtual DbSet<Admision> Admision { get; set; }
        public virtual DbSet<AgendaConvenioDetalle> AgendaConvenioDetalle { get; set; }
        public virtual DbSet<AgendaConvenios> AgendaConvenios { get; set; }
        public virtual DbSet<AgendaMedicos> AgendaMedicos { get; set; }
        public virtual DbSet<Alergias> Alergias { get; set; }
        public virtual DbSet<AlergiasPaciente> AlergiasPaciente { get; set; }
        public virtual DbSet<Cantones> Cantones { get; set; }
        public virtual DbSet<CasoConsulta> CasoConsulta { get; set; }
        public virtual DbSet<CategoriaExamenes> CategoriaExamenes { get; set; }
        public virtual DbSet<ConsultaMedica> ConsultaMedica { get; set; }
        public virtual DbSet<ControlNotas> ControlNotas { get; set; }
        public virtual DbSet<ControlSignos> ControlSignos { get; set; }
        public virtual DbSet<CosentimientoInformado> CosentimientoInformado { get; set; }
        public virtual DbSet<DatosPadres> DatosPadres { get; set; }
        public virtual DbSet<Distritos> Distritos { get; set; }
        public virtual DbSet<EmpresaConvenios> EmpresaConvenios { get; set; }
        public virtual DbSet<EntidadJuridica> EntidadJuridica { get; set; }
        public virtual DbSet<Especialidades> Especialidades { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<ExamenFisico> ExamenFisico { get; set; }
        public virtual DbSet<FacturasDetalles> FacturasDetalles { get; set; }
        public virtual DbSet<FacturasEncabezado> FacturasEncabezado { get; set; }
        public virtual DbSet<FuncionPersonalInternamiento> FuncionPersonalInternamiento { get; set; }
        public virtual DbSet<HistoriaClinica> HistoriaClinica { get; set; }
        public virtual DbSet<HistorialMedico> HistorialMedico { get; set; }
        public virtual DbSet<Internamientos> Internamientos { get; set; }
        public virtual DbSet<MedicoEspecialidad> MedicoEspecialidad { get; set; }
        public virtual DbSet<Medicos> Medicos { get; set; }
        public virtual DbSet<MotivosConsulta> MotivosConsulta { get; set; }
        public virtual DbSet<MotivosConsultaAgenda> MotivosConsultaAgenda { get; set; }
        public virtual DbSet<MotivosConsultaEspecialidad> MotivosConsultaEspecialidad { get; set; }
        public virtual DbSet<Nacionalidades> Nacionalidades { get; set; }
        public virtual DbSet<NotaOperatoria> NotaOperatoria { get; set; }
        public virtual DbSet<NotasEnfermeria> NotasEnfermeria { get; set; }
        public virtual DbSet<NotasEvolucion> NotasEvolucion { get; set; }
        public virtual DbSet<Ocupaciones> Ocupaciones { get; set; }
        public virtual DbSet<Pacientes> Pacientes { get; set; }
        public virtual DbSet<PerfilDetalleAccesoAgenda> PerfilDetalleAccesoAgenda { get; set; }
        public virtual DbSet<PersonalInternamiento> PersonalInternamiento { get; set; }
        public virtual DbSet<PlanCitas> PlanCitas { get; set; }
        public virtual DbSet<PlanesEvolucion> PlanesEvolucion { get; set; }
        public virtual DbSet<Provincias> Provincias { get; set; }
        public virtual DbSet<RecetasMedicas> RecetasMedicas { get; set; }
        public virtual DbSet<SolicitudExamenes> SolicitudExamenes { get; set; }
        public virtual DbSet<TipoAlergias> TipoAlergias { get; set; }
        public virtual DbSet<TipoIdentificacion> TipoIdentificacion { get; set; }
        public virtual DbSet<TiposExamenes> TiposExamenes { get; set; }
        public virtual DbSet<TomaSignos> TomaSignos { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");
            modelBuilder.Entity<CostarricensesBusqueda>(entity =>
            {
                entity.HasKey(e => e.CedulaIdentidad);

                entity.Property(e => e.NombreCompleto1)
                .HasColumnName("NombreCompleto1");


                entity.Property(e => e.NombreCompleto2)
                            .HasColumnName("NombreCompleto2");

                entity.Property(e => e.CedulaIdentidad)
                            .HasColumnName("CedulaIdentidad");
            });

            modelBuilder.Entity<AccesosAgenda>(entity =>
            {
            entity.HasKey(e => e.IdAcceso);

            entity.HasOne(d => d.IdMedicoNavigation)
                .WithMany(p => p.AccesosAgenda)
                .HasForeignKey(d => d.IdMedico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AccesosAgenda_Medicos");
            });

            modelBuilder.Entity<AcompannantePaciente>(entity =>
            {
                entity.HasKey(e => e.IdAcompannante);

                entity.Property(e => e.IdAcompannante).HasColumnName("idAcompannante");

                entity.Property(e => e.IdAdmision).HasColumnName("idAdmision");

                entity.Property(e => e.Identificacion)
                    .HasColumnName("identificacion")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAcompañante)
                    .HasColumnName("nombreAcompañante")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAdmisionNavigation)
                    .WithMany(p => p.AcompannantePaciente)
                    .HasForeignKey(d => d.IdAdmision)
                    .HasConstraintName("FK_AcompannantePaciente_Admision");
            });

            modelBuilder.Entity<Admision>(entity =>
            {
                entity.HasKey(e => e.IdIadmision);

                entity.Property(e => e.IdIadmision).HasColumnName("idIAdmision");

                entity.Property(e => e.CreadoPor).HasColumnName("creadoPor");

                entity.Property(e => e.DiagnosticoEgreso)
                    .HasColumnName("diagnosticoEgreso")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticoIngreso)
                    .HasColumnName("diagnosticoIngreso")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAdmision)
                    .HasColumnName("fechaAdmision")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaEgreso)
                    .HasColumnName("fechaEgreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fechaIngreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.HabitacionAsignada).HasColumnName("habitacionAsignada");

                entity.Property(e => e.ProcedimientosRealizados)
                    .HasColumnName("procedimientosRealizados")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.Admision)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Admision_Usuarios");

                entity.HasOne(d => d.InternamientoNavigation)
                    .WithMany(p => p.Admision)
                    .HasForeignKey(d => d.Internamiento)
                    .HasConstraintName("FK_Admision_Internamientos");
            });

            modelBuilder.Entity<AgendaConvenioDetalle>(entity =>
            {
                entity.HasKey(e => e.IdagendaConvenioDetalle);

                entity.Property(e => e.IdagendaConvenioDetalle).HasColumnName("IDAgendaConvenioDetalle");

                entity.Property(e => e.FechaHora).HasColumnType("datetime");

                entity.Property(e => e.IdagendaConvenio).HasColumnName("IDAgendaConvenio");

                entity.HasOne(d => d.IdEspecialidadNavigation)
                    .WithMany(p => p.AgendaConvenioDetalle)
                    .HasForeignKey(d => d.IdEspecialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AgendaConvenioDetalle_Especialidades");

                entity.HasOne(d => d.IdagendaConvenioNavigation)
                    .WithMany(p => p.AgendaConvenioDetalle)
                    .HasForeignKey(d => d.IdagendaConvenio)
                    .HasConstraintName("FK_AgendaConvenioDetalle_AgendaConvenios");
            });

            modelBuilder.Entity<AgendaConvenios>(entity =>
            {
                entity.HasKey(e => e.IdAgendaConvenio);

                entity.Property(e => e.Atendido)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cancelada)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Idconvenio).HasColumnName("IDConvenio");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdconvenioNavigation)
                    .WithMany(p => p.AgendaConvenios)
                    .HasForeignKey(d => d.Idconvenio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AgendaConvenios_EmpresaConvenios");
            });

            modelBuilder.Entity<AgendaMedicos>(entity =>
            {
                entity.HasKey(e => e.IdAgenda);

                entity.HasIndex(e => e.IdMedico);

                entity.HasIndex(e => new { e.Fecha, e.IdMedico })
                    .HasName("IX_AgendaMedicos");

                entity.Property(e => e.Atendido)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Cancelada)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.CodMedRed)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaCancela).HasColumnType("datetime");

                entity.Property(e => e.FechaConfirma).HasColumnType("datetime");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HoraPresente).HasColumnType("datetime");

                entity.Property(e => e.IdEspecialidad).HasDefaultValueSql("(0)");

                entity.Property(e => e.IdParqueo).HasColumnName("ID_PARQUEO");

                entity.Property(e => e.MotivoCancelacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreMedRed).HasMaxLength(50);

                entity.Property(e => e.Presente)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Sms).HasColumnName("SMS");

                entity.Property(e => e.SmsEmail).HasColumnName("SMS_EMAIL");

                entity.Property(e => e.Tiempo).HasDefaultValueSql("(0)");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuarioCancela)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioConfirma)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioModificador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.AgendaMedicos)
                    .HasForeignKey(d => d.IdMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AgendaMedicos_Medicos");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.AgendaMedicos)
                    .HasForeignKey(d => d.IdPaciente)
                    .HasConstraintName("FK_AgendaMedicos_Pacientes");
            });

            modelBuilder.Entity<Alergias>(entity =>
            {
                entity.HasKey(e => e.IdAlergia);

                entity.Property(e => e.HistoriaClinica).HasColumnName("historiaClinica");

                entity.Property(e => e.Medicamento).HasMaxLength(40);

                entity.HasOne(d => d.HistoriaClinicaNavigation)
                    .WithMany(p => p.Alergias)
                    .HasForeignKey(d => d.HistoriaClinica)
                    .HasConstraintName("FK_Alergias_TipoAlergias");
            });

            modelBuilder.Entity<AlergiasPaciente>(entity =>
            {
                entity.HasKey(e => new { e.IdPaciente, e.IdAlergia });

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.AlergiasPaciente)
                    .HasForeignKey(d => d.IdPaciente)
                    .HasConstraintName("FK_AlergiasPaciente_Pacientes");
            });

            modelBuilder.Entity<Cantones>(entity =>
            {
                entity.HasKey(e => e.IdCanton);

                entity.Property(e => e.IdCanton).ValueGeneratedNever();

                entity.Property(e => e.CodigoDg)
                    .HasColumnName("CodigoDG")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(substring(CONVERT([varchar],[IdCanton],0),(2),(3)))");

                entity.Property(e => e.NombreCanton)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<CasoConsulta>(entity =>
            {
                entity.HasKey(e => e.IdCaso);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HistorialGineSangrado)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HistorialGineTratamiento)
                    .HasMaxLength(2000)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.CasoConsulta)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CasoConsulta_Pacientes1");
            });

            modelBuilder.Entity<CategoriaExamenes>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.Property(e => e.Categoria)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ConsultaMedica>(entity =>
            {
                entity.HasKey(e => e.IdConsulta);

                entity.HasIndex(e => e.IdAgenda)
                    .HasName("IX_ConsultaMedica")
                    .IsUnique();

                entity.Property(e => e.DescripcionMotivoConsulta).HasMaxLength(2000);

                entity.Property(e => e.Diagnostico).HasMaxLength(2000);

                entity.Property(e => e.E).HasMaxLength(50);

                entity.Property(e => e.Eg)
                    .HasColumnName("EG")
                    .HasMaxLength(100);

                entity.Property(e => e.Estatura).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExamenFisico).HasMaxLength(2000);

                entity.Property(e => e.FechaConsulta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaProxCita).HasColumnType("datetime");

                entity.Property(e => e.Fpp)
                    .HasColumnName("FPP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fur)
                    .HasColumnName("FUR")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gpac)
                    .HasColumnName("GPAC")
                    .HasMaxLength(50);

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Presion).HasMaxLength(20);

                entity.Property(e => e.ProgramadaCita)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ProgramarCita)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ProgramarCitaDias).HasDefaultValueSql("(0)");

                entity.Property(e => e.RecetaImpresa)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.Tratamiento).HasMaxLength(2000);

                entity.Property(e => e.UsuarioImpReceta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.IdAgendaNavigation)
                    .WithOne(p => p.ConsultaMedica)
                    .HasForeignKey<ConsultaMedica>(d => d.IdAgenda)
                    .HasConstraintName("FK_ConsultaMedica_AgendaMedicos");
            });

            modelBuilder.Entity<ControlNotas>(entity =>
            {
                entity.HasKey(e => e.IdControlNotas);

                entity.Property(e => e.IdControlNotas).HasColumnName("idControlNotas");

                entity.Property(e => e.CreadoPor).HasColumnName("creadoPor");

                entity.Property(e => e.FechaNota)
                    .HasColumnName("fechaNota")
                    .HasColumnType("datetime");

                entity.Property(e => e.MedicamentoSuministrado)
                    .HasColumnName("medicamentoSuministrado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nota)
                    .HasColumnName("nota")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.NotasEnfermeria).HasColumnName("notasEnfermeria");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.ControlNotas)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_ControlNotas_Usuarios");

                entity.HasOne(d => d.NotasEnfermeriaNavigation)
                    .WithMany(p => p.ControlNotas)
                    .HasForeignKey(d => d.NotasEnfermeria)
                    .HasConstraintName("FK_ControlNotas_NotasEnfermeria");
            });

            modelBuilder.Entity<ControlSignos>(entity =>
            {
                entity.HasKey(e => e.IdControlSignos);

                entity.Property(e => e.IdControlSignos).HasColumnName("idControlSignos");

                entity.HasOne(d => d.InternamientoNavigation)
                    .WithMany(p => p.ControlSignos)
                    .HasForeignKey(d => d.Internamiento)
                    .HasConstraintName("FK_ControlSignos_Internamientos");
            });

            modelBuilder.Entity<CosentimientoInformado>(entity =>
            {
                entity.HasKey(e => e.IdConsentimiento);

                entity.Property(e => e.IdConsentimiento)
                    .HasColumnName("idConsentimiento")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArchivoConsentimiento)
                    .HasColumnName("archivoConsentimiento")
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor).HasColumnName("creadoPor");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.CosentimientoInformado)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_CosentimientoInformado_Usuarios");

                entity.HasOne(d => d.InternamientoNavigation)
                    .WithMany(p => p.CosentimientoInformado)
                    .HasForeignKey(d => d.Internamiento)
                    .HasConstraintName("FK_CosentimientoInformado_Internamientos");
            });

            modelBuilder.Entity<DatosPadres>(entity =>
            {
                entity.HasKey(e => e.IdDatosPadres);

                entity.Property(e => e.IdDatosPadres).HasColumnName("idDatosPadres");

                entity.Property(e => e.IdentificacionMadre)
                    .HasColumnName("identificacionMadre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificacionPadre)
                    .HasColumnName("identificacionPadre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreMadre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePadre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.PacienteNavigation)
                    .WithMany(p => p.DatosPadresNavigation)
                    .HasForeignKey(d => d.Paciente)
                    .HasConstraintName("FK_DatosPadres_Pacientes");
            });

            modelBuilder.Entity<Distritos>(entity =>
            {
                entity.HasKey(e => e.IdDistrito);

                entity.Property(e => e.IdDistrito).ValueGeneratedNever();

                entity.Property(e => e.Cdg3)
                    .HasColumnName("CDG3")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Cdg4)
                    .HasColumnName("CDG4")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoDg1)
                    .HasColumnName("CodigoDG1")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(substring(CONVERT([varchar],[IdCanton],0),(1),(1)))");

                entity.Property(e => e.CodigoDg2)
                    .HasColumnName("CodigoDG2")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(substring(CONVERT([varchar],[IdCanton],0),(2),(3)))");

                entity.Property(e => e.IdCanton).HasDefaultValueSql("(0)");

                entity.Property(e => e.NombreDistrito)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<EmpresaConvenios>(entity =>
            {
                entity.HasKey(e => e.IdConvenio)
                    .HasName("PK_EmpresaConvenios2");

                entity.Property(e => e.IdConvenio).HasColumnName("ID_Convenio");

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Contacto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaContable)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('9-1-02-02-003')");

                entity.Property(e => e.DescripcionCc)
                    .IsRequired()
                    .HasColumnName("DescripcionCC")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Cuenta Puente Cuentas por Cobrar')");

                entity.Property(e => e.Email)
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.EmpresaConvenio)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.Identificacion)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Incluye)
                    .HasColumnName("incluye")
                    .HasColumnType("ntext");

                entity.Property(e => e.LimiteCreditoLocal).HasColumnName("LimiteCredito_Local");

                entity.Property(e => e.NombreCorto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroContrato)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlazoDeCredito).HasColumnName("Plazo_de_Credito");

                entity.Property(e => e.Telefono01)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono02)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo).HasDefaultValueSql("((0))");

                entity.Property(e => e.TramiteDeFacturas)
                    .HasColumnName("Tramite_de_facturas")
                    .HasColumnType("ntext");

                entity.Property(e => e.UsuarioActualiza)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreador)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VenceContrato).HasColumnType("date");
            });

            modelBuilder.Entity<EntidadJuridica>(entity =>
            {
                entity.HasKey(e => e.IdEmpresa);

                entity.Property(e => e.IdEmpresa).ValueGeneratedNever();

                entity.Property(e => e.Cedula)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CodCompYam)
                    .IsRequired()
                    .HasColumnName("CodCompYAM")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Frase)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Telefonos)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Especialidades>(entity =>
            {
                entity.HasKey(e => e.IdEspecialidad);

                entity.Property(e => e.ActivoRm).HasColumnName("ActivoRM");

                entity.Property(e => e.NombreEspecialidad)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<EstadoCivil>(entity =>
            {
                entity.HasKey(e => e.IdEstadoCivil);

                entity.Property(e => e.IdEstadoCivil).ValueGeneratedOnAdd();

                entity.Property(e => e.EstadoCivil1)
                    .IsRequired()
                    .HasColumnName("EstadoCivil")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ExamenFisico>(entity =>
            {
                entity.HasKey(e => e.IdExamenFisico);

                entity.Property(e => e.IdExamenFisico).HasColumnName("idExamenFisico");

                entity.Property(e => e.Aspecto)
                    .HasColumnName("aspecto")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAplicacion)
                    .HasColumnName("fechaAplicacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FrecuenciaCardiaca).HasColumnName("frecuenciaCardiaca");

                entity.Property(e => e.FrecuenciaRespiratoria).HasColumnName("frecuenciaRespiratoria");

                entity.Property(e => e.HistoriaClinica).HasColumnName("historiaClinica");

                entity.Property(e => e.Peso).HasColumnName("peso");

                entity.Property(e => e.PresionArterial)
                    .HasColumnName("presionArterial")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SaturacionOxigeno).HasColumnName("saturacionOxigeno");

                entity.Property(e => e.Talla).HasColumnName("talla");

                entity.Property(e => e.Temperatura).HasColumnName("temperatura");

                entity.HasOne(d => d.HistoriaClinicaNavigation)
                    .WithMany(p => p.ExamenFisico)
                    .HasForeignKey(d => d.HistoriaClinica)
                    .HasConstraintName("FK_ExamenFisico_HistoriaClinica");
            });

            modelBuilder.Entity<FacturasDetalles>(entity =>
            {
                entity.HasKey(e => e.IdFacturasDetalles);

                entity.Property(e => e.Bodega)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CuentaContable)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EsCanasta)
                    .HasColumnName("Es_Canasta")
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'N')");

                entity.Property(e => e.FechaEmision).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lote)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MontoExoneracion).HasDefaultValueSql("((0))");

                entity.Property(e => e.NombreInstitucion).HasMaxLength(50);

                entity.Property(e => e.NumeroDocumento).HasMaxLength(20);

                entity.Property(e => e.Obs)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Origen)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PorcentageIv).HasColumnName("PorcentageIV");

                entity.Property(e => e.PorcentajeExoneracion).HasDefaultValueSql("((0))");

                entity.Property(e => e.TipoDocumento).HasMaxLength(20);

                entity.Property(e => e.TipoImpuesto)
                    .HasColumnName("Tipo_Impuesto")
                    .HasMaxLength(2);

                entity.Property(e => e.TipoTarifa)
                    .HasColumnName("Tipo_Tarifa")
                    .HasMaxLength(2);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdFacturaNavigation)
                    .WithMany(p => p.FacturasDetalles)
                    .HasForeignKey(d => d.IdFactura)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FacturasDetalles_FacturasEncabezado");
            });

            modelBuilder.Entity<FacturasEncabezado>(entity =>
            {
                entity.HasKey(e => e.IdFactura);

                entity.HasIndex(e => e.Fecha)
                    .HasName("IX_FacturasEncabezado_fecha");

                entity.HasIndex(e => new { e.NumeroFactura, e.TipoFactura, e.PuntoVenta })
                    .HasName("IX_FacturasEncabezado_Fact_Tipo_Punto");

                entity.Property(e => e.Apellido1Cliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2Cliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AplicacadoIvaDevuelto).HasColumnName("Aplicacado_IVA_Devuelto");

                entity.Property(e => e.AutorizacionDescuento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CertificadoNumero).HasDefaultValueSql("((0))");

                entity.Property(e => e.ClientePagador)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoTurno)
                    .IsRequired()
                    .HasColumnName("Codigo_Turno")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0000')");

                entity.Property(e => e.ConsecutivoExactus)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DescuentoDolar).HasComputedColumnSql("(case when [IDMoneda]=(1) then [descuento]/[TCC] else [Descuento]/[TipoCambio] end)");

                entity.Property(e => e.Entidad).HasDefaultValueSql("((1))");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FechaMigrado).HasColumnType("datetime");

                entity.Property(e => e.FechaNotaCreExactus).HasColumnType("datetime");

                entity.Property(e => e.FechaPreAnulado).HasColumnType("datetime");

                entity.Property(e => e.Fp)
                    .HasColumnName("FP")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.IdConvenio).HasColumnName("ID_Convenio");

                entity.Property(e => e.IdentificacionCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idmoneda)
                    .HasColumnName("IDMoneda")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Iht).HasColumnName("IHT");

                entity.Property(e => e.ImpuestoDolar).HasComputedColumnSql("(case when [IDMoneda]=(1) then [ImpuestoVenta]/[TCC] else [ImpuestoVenta]/[TipoCambio] end)");

                entity.Property(e => e.Nic)
                    .HasColumnName("NIC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NotaCreditoExactus)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrdenServicio)
                    .HasColumnName("Orden_Servicio")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Plazo).HasDefaultValueSql("((30))");

                entity.Property(e => e.Proformada).HasDefaultValueSql("((0))");

                entity.Property(e => e.Promotor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotalDolar).HasComputedColumnSql("(case when [IDMoneda]=(1) then [SubTotal]/[TCC] else [SubTotal]/[TipoCambio] end)");

                entity.Property(e => e.Tcc)
                    .HasColumnName("TCC")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tcv)
                    .HasColumnName("TCV")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoCambio).HasDefaultValueSql("((1))");

                entity.Property(e => e.TipoFactura)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TotalDolar).HasComputedColumnSql("(case when [IDMoneda]=(1) then [Total]/[TCC] else [Total]/[TipoCambio] end)");

                entity.Property(e => e.TotalIvadevuelto).HasColumnName("TotalIVADevuelto");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UsuarioAutoAnulado).HasMaxLength(50);

                entity.HasOne(d => d.IdConsultaNavigation)
                    .WithMany(p => p.FacturasEncabezado)
                    .HasForeignKey(d => d.IdConsulta)
                    .HasConstraintName("FK_FacturasEncabezado_ConsultaMedica");
            });

            modelBuilder.Entity<FuncionPersonalInternamiento>(entity =>
            {
                entity.HasKey(e => e.IdFuncionMedico);

                entity.Property(e => e.IdFuncionMedico).HasColumnName("idFuncionMedico");

                entity.Property(e => e.DescripcionFuncion)
                    .HasColumnName("descripcionFuncion")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HistoriaClinica>(entity =>
            {
                entity.HasKey(e => e.IdIhistoriaClinica);

                entity.Property(e => e.IdIhistoriaClinica).HasColumnName("idIHistoriaClinica");

                entity.Property(e => e.Abdomen)
                    .HasColumnName("abdomen")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Afh)
                    .HasColumnName("AFH")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ago)
                    .HasColumnName("AGO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.App)
                    .HasColumnName("APP")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Aqxt)
                    .HasColumnName("AQXT")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Cardiaco)
                    .HasColumnName("cardiaco")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor).HasColumnName("creadoPor");

                entity.Property(e => e.Cuello)
                    .HasColumnName("cuello")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoNeurológico)
                    .HasColumnName("estadoNeurológico")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoVacunacion).HasColumnName("estadoVacunacion");

                entity.Property(e => e.Extremidades)
                    .HasColumnName("extremidades")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHistoria)
                    .HasColumnName("fechaHistoria")
                    .HasColumnType("datetime");

                entity.Property(e => e.Oftalmológico)
                    .HasColumnName("oftalmológico")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Orl)
                    .HasColumnName("ORL")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OtrosDatos)
                    .HasColumnName("otrosDatos")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaladarDentadura)
                    .HasColumnName("paladarDentadura")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Peso).HasColumnName("peso");

                entity.Property(e => e.PielAnexos)
                    .HasColumnName("pielAnexos")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Pulsos)
                    .HasColumnName("pulsos")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Servicio)
                    .HasColumnName("servicio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TactoRectal)
                    .HasColumnName("tactoRectal")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TactoVaginal)
                    .HasColumnName("tactoVaginal")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Talla).HasColumnName("talla");

                entity.Property(e => e.ToraxPulmonar)
                    .HasColumnName("toraxPulmonar")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TratamientoActual)
                    .HasColumnName("tratamientoActual")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.HistoriaClinica)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_HistoriaClinica_Usuarios");

                entity.HasOne(d => d.InternamientoNavigation)
                    .WithMany(p => p.HistoriaClinica)
                    .HasForeignKey(d => d.Internamiento)
                    .HasConstraintName("FK_HistoriaClinica_Internamientos");
            });

            modelBuilder.Entity<HistorialMedico>(entity =>
            {
                entity.HasKey(e => e.IdPaciente);

                entity.HasIndex(e => e.IdPaciente)
                    .HasName("IX_HistorialMedico")
                    .IsUnique();

                entity.Property(e => e.IdPaciente).ValueGeneratedNever();

                entity.Property(e => e.HistorialClinico).HasMaxLength(2000);

                entity.Property(e => e.HistorialFamiliar).HasMaxLength(2000);

                entity.Property(e => e.HistorialNoPatogeno).HasMaxLength(2000);

                entity.Property(e => e.HistorialPatogeno).HasMaxLength(2000);

                entity.Property(e => e.IdHistorialMedico).ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithOne(p => p.HistorialMedico)
                    .HasForeignKey<HistorialMedico>(d => d.IdPaciente)
                    .HasConstraintName("FK_HistorialMedico_Pacientes");
            });

            modelBuilder.Entity<Internamientos>(entity =>
            {
                entity.HasKey(e => e.IdInternamiento);

                entity.Property(e => e.IdInternamiento).HasColumnName("idInternamiento");

                entity.Property(e => e.CreadoPor).HasColumnName("creadoPor");

                entity.Property(e => e.EstadoInternamiento)
                    .HasColumnName("estadoInternamiento")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.Internamientos)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_Internamientos_Usuarios");

                entity.HasOne(d => d.PacienteInternamientoNavigation)
                    .WithMany(p => p.Internamientos)
                    .HasForeignKey(d => d.PacienteInternamiento)
                    .HasConstraintName("FK_Internamientos_Pacientes");
            });

            modelBuilder.Entity<MedicoEspecialidad>(entity =>
            {
                entity.HasKey(e => e.IdMedicoEspecialidad);

                entity.HasOne(d => d.IdEspecialidadNavigation)
                    .WithMany(p => p.MedicoEspecialidad)
                    .HasForeignKey(d => d.IdEspecialidad)
                    .HasConstraintName("FK_MedicoEspecialidad_Especialidades");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.MedicoEspecialidad)
                    .HasForeignKey(d => d.IdMedico)
                    .HasConstraintName("FK_MedicoEspecialidad_Medicos");
            });

            modelBuilder.Entity<Medicos>(entity =>
            {
                entity.HasKey(e => e.IdMedico);

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ActivoEmergencias)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ActivoFacturador).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActivoParaConvenios)
                    .IsRequired()
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.ActivoSiempre).HasDefaultValueSql("((0))");

                entity.Property(e => e.Apellido1)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(30)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Banco)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CarpetaReportes)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Categoria).HasDefaultValueSql("(0)");

                entity.Property(e => e.Cedula).HasMaxLength(15);

                entity.Property(e => e.CodMedico).HasMaxLength(10);

                entity.Property(e => e.ComisionTarjeta).HasDefaultValueSql("(4.05)");

                entity.Property(e => e.CuentaBancaria)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Entidad).HasDefaultValueSql("(1)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.FormatoImpresora).HasDefaultValueSql("(0)");

                entity.Property(e => e.Grado)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.HoraFinal)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('22:00:00')");

                entity.Property(e => e.HoraInicio)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('07:00:00')");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(112)
                    .HasComputedColumnSql("(rtrim(ltrim(((([Apellido1]+' ')+[Apellido2])+' ')+[Nombre])))");

                entity.Property(e => e.PorcentajeMedico).HasDefaultValueSql("(0)");

                entity.Property(e => e.Telefono1)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Telefono2)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TiempoEntreConsultas).HasDefaultValueSql("(15)");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario).HasMaxLength(50);

                entity.HasOne(d => d.EntidadNavigation)
                    .WithMany(p => p.Medicos)
                    .HasForeignKey(d => d.Entidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Medicos_EntidadJuridica");
            });

            modelBuilder.Entity<MotivosConsulta>(entity =>
            {
                entity.HasKey(e => e.IdMotivoConsulta);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MotivosConsultaAgenda>(entity =>
            {
                entity.HasKey(e => new { e.IdMotivoConsulta, e.IdAgenda });

                entity.Property(e => e.FechaAgregado)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdmMca)
                    .HasColumnName("IdmMCA")
                    .ValueGeneratedOnAdd();

                entity.HasOne(d => d.IdAgendaNavigation)
                    .WithMany(p => p.MotivosConsultaAgenda)
                    .HasForeignKey(d => d.IdAgenda)
                    .HasConstraintName("FK_MotivosConsultaAgenda_AgendaMedicos");

                entity.HasOne(d => d.IdMotivoConsultaNavigation)
                    .WithMany(p => p.MotivosConsultaAgenda)
                    .HasForeignKey(d => d.IdMotivoConsulta)
                    .HasConstraintName("FK_MotivosConsultaAgenda_MotivosConsulta");
            });

            modelBuilder.Entity<MotivosConsultaEspecialidad>(entity =>
            {
                entity.HasKey(e => new { e.IdMotivoConsulta, e.IdEspecialidad });

                entity.Property(e => e.IdMce)
                    .HasColumnName("IdMCE")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Nacionalidades>(entity =>
            {
                entity.HasKey(e => e.IdNacionalidad);

                entity.Property(e => e.CodigoInternacional)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NombrePais)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<NotaOperatoria>(entity =>
            {
                entity.HasKey(e => e.IdNotaOperatoria);

                entity.Property(e => e.IdNotaOperatoria).HasColumnName("idNotaOperatoria");

                entity.Property(e => e.CirugíaRealizada)
                    .HasColumnName("cirugíaRealizada")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor).HasColumnName("creadoPor");

                entity.Property(e => e.DiagnosticoPostoperatorio)
                    .HasColumnName("diagnosticoPostoperatorio")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticoPreoperatorio)
                    .HasColumnName("diagnosticoPreoperatorio")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNota)
                    .HasColumnName("fechaNota")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hallazgos)
                    .HasColumnName("hallazgos")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TecnicaEmpleada)
                    .HasColumnName("tecnicaEmpleada")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.NotaOperatoria)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_NotaOperatoria_Usuarios");

                entity.HasOne(d => d.InternamientoNavigation)
                    .WithMany(p => p.NotaOperatoria)
                    .HasForeignKey(d => d.Internamiento)
                    .HasConstraintName("FK_NotaOperatoria_Internamientos");
            });

            modelBuilder.Entity<NotasEnfermeria>(entity =>
            {
                entity.HasKey(e => e.IdNotaEnfermeria);

                entity.Property(e => e.IdNotaEnfermeria).HasColumnName("idNotaEnfermeria");

                entity.HasOne(d => d.InternamientoNavigation)
                    .WithMany(p => p.NotasEnfermeria)
                    .HasForeignKey(d => d.Internamiento)
                    .HasConstraintName("FK_idNotaEnfermeria_Internamientos");
            });

            modelBuilder.Entity<NotasEvolucion>(entity =>
            {
                entity.HasKey(e => e.IdNotaEvolucion)
                    .HasName("PK_NotasEvolución");

                entity.Property(e => e.IdNotaEvolucion).HasColumnName("idNotaEvolucion");

                entity.Property(e => e.EstadoNota)
                    .HasColumnName("estadoNota")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FechaNota)
                    .HasColumnName("fechaNota")
                    .HasColumnType("datetime");

                entity.Property(e => e.Indicaciones)
                    .HasColumnName("indicaciones")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Nota)
                    .HasColumnName("nota")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PlanEvolucion).HasColumnName("planEvolucion");

                entity.HasOne(d => d.PlanEvolucionNavigation)
                    .WithMany(p => p.NotasEvolucion)
                    .HasForeignKey(d => d.PlanEvolucion)
                    .HasConstraintName("FK_NotasEvolucion_PlanesEvolucion1");
            });

            modelBuilder.Entity<Ocupaciones>(entity =>
            {
                entity.HasKey(e => e.IdOcupacion);

                entity.HasIndex(e => e.Ocupacion)
                    .HasName("IX_Ocupaciones")
                    .IsUnique();

                entity.Property(e => e.Ocupacion)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Pacientes>(entity =>
            {
                entity.HasKey(e => e.IdPaciente);

                entity.HasIndex(e => e.Apellido1);

                entity.HasIndex(e => e.Apellido2);

                entity.HasIndex(e => e.IdPaciente)
                    .HasName("IX_Pacientes_Nombre");

                entity.HasIndex(e => e.Identificacion)
                    .HasName("IX_Pacientes_Indentificacion")
                    .IsUnique();

                entity.Property(e => e.Activo)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(26);

                entity.Property(e => e.Apellido1Conyuge).HasMaxLength(26);

                entity.Property(e => e.Apellido2)
                    .HasMaxLength(26)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Apellido2Conyuge).HasMaxLength(26);

                entity.Property(e => e.ClienteExactus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Csenc)
                    .HasColumnName("CSENC")
                    .HasMaxLength(50);

                entity.Property(e => e.DatosPadres).HasColumnName("datosPadres");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EdadActual)
                    .HasMaxLength(110)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(((((CONVERT([varchar],floor(CONVERT([float],datediff(day,[FechaNacimiento],getdate()),(0))/(365)),(0))+' Años, ')+CONVERT([varchar],floor((CONVERT([float],datediff(day,[FechaNacimiento],getdate()),(0))/(365)-floor(CONVERT([float],datediff(day,[FechaNacimiento],getdate()),(0))/(365)))*(12)),(0)))+' Meses, ')+CONVERT([varchar],floor(((CONVERT([float],datediff(day,[FechaNacimiento],getdate()),(0))/(365)-floor(CONVERT([float],datediff(day,[FechaNacimiento],getdate()),(0))/(365)))*(12)-floor((CONVERT([float],datediff(day,[FechaNacimiento],getdate()),(0))/(365)-floor(CONVERT([float],datediff(day,[FechaNacimiento],getdate()),(0))/(365)))*(12)))*((365)/(12))),(0)))+' Días')");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50);

                entity.Property(e => e.Email2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualiza).HasColumnType("datetime");

                entity.Property(e => e.FechaNacimiento).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Genero).HasMaxLength(1);

                entity.Property(e => e.GrupoSanguineo).HasMaxLength(8);

                entity.Property(e => e.IdNacionalidad).HasDefaultValueSql("((49))");

                entity.Property(e => e.IdTipoIdentificacion).HasDefaultValueSql("((1))");

                entity.Property(e => e.IdconverioEmpresas)
                    .HasColumnName("IDConverioEmpresas")
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LugarNacimiento)
                    .HasColumnName("lugarNacimiento")
                    .HasMaxLength(10);

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NitApellido1)
                    .HasColumnName("NIT_APELLIDO1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NitApellido2)
                    .HasColumnName("NIT_APELLIDO2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NitNombre)
                    .HasColumnName("NIT_NOMBRE")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NitNombrecompleto)
                    .HasColumnName("NIT_NOMBRECOMPLETO")
                    .HasMaxLength(252)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(((([NIT_Apellido1]+case when len([NIT_apellido2])>(1) then ' ' else '' end)+[NIT_Apellido2])+case when len([NIT_Nombre])>(1) then ' ' else '' end)+[NIT_Nombre])");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(204)
                    .HasComputedColumnSql("(((([Apellido1]+case when len([apellido2])>(1) then ' ' else '' end)+[Apellido2])+case when len([Nombre])>(1) then ' ' else '' end)+[Nombre])");

                entity.Property(e => e.NombreConyuge).HasMaxLength(30);

                entity.Property(e => e.NumSeguro)
                    .HasColumnName("numSeguro")
                    .HasMaxLength(20);

                entity.Property(e => e.OtrasSeñas).HasMaxLength(255);

                entity.Property(e => e.Rh)
                    .HasColumnName("RH")
                    .HasMaxLength(8);

                entity.Property(e => e.TelefonoHabitacion)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TelefonoMovil)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.TelefonoMovilConyuge).HasMaxLength(8);

                entity.Property(e => e.TelefonoOficinaConyuge).HasMaxLength(8);

                entity.Property(e => e.TelefonoTrabajo)
                    .HasMaxLength(8)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Registro Automatico')");

                entity.HasOne(d => d.IdCantonNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdCanton)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Pacientes_Cantones");

                entity.HasOne(d => d.IdEstadoCivilNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdEstadoCivil)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Pacientes_EstadoCivil");

                entity.HasOne(d => d.IdNacionalidadNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdNacionalidad)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Pacientes_Nacionalidades");

                entity.HasOne(d => d.IdOcupacionNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdOcupacion)
                    .HasConstraintName("FK_Pacientes_Ocupaciones");

                entity.HasOne(d => d.IdProvinciaNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdProvincia)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Pacientes_Provincias");

                entity.HasOne(d => d.IdTipoIdentificacionNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdTipoIdentificacion)
                    .HasConstraintName("FK_Pacientes_TipoIdentificacion");
            });

            modelBuilder.Entity<PerfilDetalleAccesoAgenda>(entity =>
            {
                entity.HasKey(e => e.IdPerfilDetalle)
                    .HasName("PK_Perfil__Detalle_Acceso_Agenda");

                entity.ToTable("Perfil_Detalle_Acceso_Agenda");

                entity.HasIndex(e => e.IdPerfilDetalle)
                    .HasName("IX_Perfil_Detalle_Acceso_Agenda");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.PerfilDetalleAccesoAgenda)
                    .HasForeignKey(d => d.IdMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Perfil_Detalle_Acceso_Agenda_Medicos");
            });

            modelBuilder.Entity<PersonalInternamiento>(entity =>
            {
                entity.HasKey(e => e.IdPersonalMedico);

                entity.Property(e => e.IdPersonalMedico).HasColumnName("idPersonalMedico");

                entity.HasOne(d => d.IdFuncionNavigation)
                    .WithMany(p => p.PersonalInternamiento)
                    .HasForeignKey(d => d.IdFuncion)
                    .HasConstraintName("FK_PersonalInternamiento_FuncionPersonalInternamiento");

                entity.HasOne(d => d.IdMedicoNavigation)
                    .WithMany(p => p.PersonalInternamiento)
                    .HasForeignKey(d => d.IdMedico)
                    .HasConstraintName("FK_PersonalInternamiento_Medicos");

                entity.HasOne(d => d.InternamientoNavigation)
                    .WithMany(p => p.PersonalInternamiento)
                    .HasForeignKey(d => d.Internamiento)
                    .HasConstraintName("FK_PersonalInternamiento_Internamientos");
            });

            modelBuilder.Entity<PlanCitas>(entity =>
            {
                entity.HasKey(e => e.IdPlan);

                entity.Property(e => e.IdPlan).ValueGeneratedNever();

                entity.Property(e => e.Especialidad)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Medico)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.IdConsultaNavigation)
                    .WithMany(p => p.PlanCitas)
                    .HasForeignKey(d => d.IdConsulta)
                    .HasConstraintName("FK_PlanCitas_ConsultaMedica");
            });

            modelBuilder.Entity<PlanesEvolucion>(entity =>
            {
                entity.HasKey(e => e.IdPlanesEvolucion);

                entity.Property(e => e.IdPlanesEvolucion).HasColumnName("idPlanesEvolucion");

                entity.Property(e => e.CreadoPor).HasColumnName("creadoPor");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.PlanesEvolucion)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_PlanesEvolucion_Usuarios");

                entity.HasOne(d => d.InternamientoNavigation)
                    .WithMany(p => p.PlanesEvolucion)
                    .HasForeignKey(d => d.Internamiento)
                    .HasConstraintName("FK_PlanesEvolucion_Internamientos");
            });

            modelBuilder.Entity<Provincias>(entity =>
            {
                entity.HasKey(e => e.IdProvincia);

                entity.Property(e => e.NombreProvincia)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<RecetasMedicas>(entity =>
            {
                entity.HasKey(e => e.IdDetalleRecetas);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dosis)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Presentacion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdConsultaNavigation)
                    .WithMany(p => p.RecetasMedicas)
                    .HasForeignKey(d => d.IdConsulta)
                    .HasConstraintName("FK_RecetasMedicas_ConsultaMedica");
            });

            modelBuilder.Entity<SolicitudExamenes>(entity =>
            {
                entity.HasKey(e => e.IdSolicitudesExamen);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdConsultaNavigation)
                    .WithMany(p => p.SolicitudExamenes)
                    .HasForeignKey(d => d.IdConsulta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudExamenes_ConsultaMedica");

                entity.HasOne(d => d.IdExamenNavigation)
                    .WithMany(p => p.SolicitudExamenes)
                    .HasForeignKey(d => d.IdExamen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolicitudExamenes_TiposExamenes");
            });

            modelBuilder.Entity<TipoAlergias>(entity =>
            {
                entity.HasKey(e => e.IdTipoAlergia);

                entity.Property(e => e.IdTipoAlergia).HasColumnName("idTipoAlergia");

                entity.Property(e => e.Alergias).HasColumnName("alergias");

                entity.Property(e => e.NombreAlergia)
                    .HasColumnName("nombreAlergia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.AlergiasNavigation)
                    .WithMany(p => p.TipoAlergias)
                    .HasForeignKey(d => d.Alergias)
                    .HasConstraintName("FK_TipoAlergias_Alergias");
            });

            modelBuilder.Entity<TipoIdentificacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoIdentificacion);

                entity.Property(e => e.Mascara).HasMaxLength(15);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TipoIdentificacion1)
                    .IsRequired()
                    .HasColumnName("TipoIdentificacion")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TiposExamenes>(entity =>
            {
                entity.HasKey(e => e.IdExamenes);

                entity.Property(e => e.NombreExamen)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.TiposExamenes)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TiposExamenes_CategoriaExamenes");
            });

            modelBuilder.Entity<TomaSignos>(entity =>
            {
                entity.HasKey(e => e.IdTomaSignos);

                entity.Property(e => e.IdTomaSignos).HasColumnName("idTomaSignos");

                entity.Property(e => e.ControlSignos).HasColumnName("controlSignos");

                entity.Property(e => e.CreadoPor).HasColumnName("creadoPor");

                entity.Property(e => e.FechaToma)
                    .HasColumnName("fechaToma")
                    .HasColumnType("datetime");

                entity.Property(e => e.FrecienciaCardiaca)
                    .HasColumnName("frecienciaCardiaca")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FrecuenciaRespiratoria)
                    .HasColumnName("frecuenciaRespiratoria")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PresionArterial)
                    .HasColumnName("presionArterial")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaturacionOxigeno)
                    .HasColumnName("saturacionOxigeno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temperatura)
                    .HasColumnName("temperatura")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ControlSignosNavigation)
                    .WithMany(p => p.TomaSignos)
                    .HasForeignKey(d => d.ControlSignos)
                    .HasConstraintName("FK_TomaSignos_ControlSignos");

                entity.HasOne(d => d.CreadoPorNavigation)
                    .WithMany(p => p.TomaSignos)
                    .HasForeignKey(d => d.CreadoPor)
                    .HasConstraintName("FK_TomaSignos_Usuarios");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsusario);

                entity.Property(e => e.AsociarAMedico)
                    .HasColumnName("Asociar_a_Medico")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.BloquearPc)
                    .IsRequired()
                    .HasColumnName("BloquearPC")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(75)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ClaveEntrada)
                    .IsRequired()
                    .HasColumnName("Clave_Entrada")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CodPromotor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpImpFac).HasDefaultValueSql("((0))");

                entity.Property(e => e.Foto).HasColumnType("image");

                entity.Property(e => e.IdCajaAsignada).HasDefaultValueSql("((1))");

                entity.Property(e => e.IdMedico).HasDefaultValueSql("((-1))");

                entity.Property(e => e.LugarAcceso).HasMaxLength(25);

                entity.Property(e => e.ModificadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Perfil).HasDefaultValueSql("((1))");

                entity.Property(e => e.Tel01)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.UltimoAcceso).HasColumnType("datetime");
            });
        }
    }
}
