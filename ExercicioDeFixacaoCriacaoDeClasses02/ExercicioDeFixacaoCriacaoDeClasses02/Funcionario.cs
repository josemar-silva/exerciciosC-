using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioDeFixacaoCriacaoDeClasses02 {
    class Funcionario {
        private string _nome;
        private double _salario;
        public int MembrosFamilia { get; set; }

        public Funcionario(string nome, double salario, int membrosFamilia) {
            _nome = nome;
            _salario = salario;
            MembrosFamilia = membrosFamilia;
        }

        public string Nome {
            get { return _nome; }
            set { if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double Salario {
            get { return _salario; }
            set { if (value > _salario) {
                    _salario = value;
                } 
            }
        }

        public double MediaSalario() {

            double rendaMedia = _salario / MembrosFamilia;
            return rendaMedia;
        }

            public override string ToString() {
            return "A media salarial da familia do funcionario " + _nome + " é de R$ "
                + MediaSalario().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    }

