using CadastroEventosApp.Models;
using System.ComponentModel;

namespace CadastroEventosApp.ViewModels
{
    public class CadastroEventoViewModel : INotifyPropertyChanged
    {
        private Evento _evento;

        public CadastroEventoViewModel()
        {
            _evento = new Evento();
        }

        public string Nome
        {
            get => _evento.Nome;
            set
            {
                _evento.Nome = value;
                OnPropertyChanged(nameof(Nome));
            }
        }

        public DateTime DataInicio
        {
            get => _evento.DataInicio;
            set
            {
                _evento.DataInicio = value;
                OnPropertyChanged(nameof(DataInicio));
            }
        }

        public DateTime DataTermino
        {
            get => _evento.DataTermino;
            set
            {
                _evento.DataTermino = value;
                OnPropertyChanged(nameof(DataTermino));
            }
        }

        public int NumeroParticipantes
        {
            get => _evento.NumeroParticipantes;
            set
            {
                _evento.NumeroParticipantes = value;
                OnPropertyChanged(nameof(NumeroParticipantes));
            }
        }

        public string Local
        {
            get => _evento.Local;
            set
            {
                _evento.Local = value;
                OnPropertyChanged(nameof(Local));
            }
        }

        public decimal CustoPorParticipante
        {
            get => _evento.CustoPorParticipante;
            set
            {
                _evento.CustoPorParticipante = value;
                OnPropertyChanged(nameof(CustoPorParticipante));
            }
        }

        public int DuracaoEventoEmDias => _evento.DuracaoEventoEmDias;
        public decimal CustoTotal => _evento.CustoTotal;

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
