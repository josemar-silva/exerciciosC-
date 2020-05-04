using System.Globalization;
namespace Course {
    class Produto {
        public string _nome; 
        public double _preco; 
        public int _quantidade;

        public Produto() { // possibilita instanciar objeto sem receber parametro algum
        }
        public Produto(string nome, double preco) {
            _nome = nome;
            _preco = preco;
        }
        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set { if (value != null && value.Length > 1){
                    _nome = value;
                }
            }
        }

        public double Preco {
            get { return _preco; }
        }

        public int Quantiddade {
            get { return _quantidade; }
            set { _quantidade = value; }
        }
        
        /* Esta seria a fomra de acesso aos atributos utilizando Get e Set, 
         * porem iremos utilizar uma definicao mais amigavel que são as PREOPRIEDADES ou PROPERTIES no C#/1
         * 
         * public string GetNome() {
            return _nome;
        }

        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome;
            }
        }

        public double GetPreco() {
            return _preco;
        }

        public void SetPreco( double preco) {
            _preco = preco;
        }

        public int GetQuantidade() {
            return _quantidade;
        }

        public void SetQuantidade(int quantidade) {
            if(_quantidade < quantidade) {
                _quantidade = quantidade;
            }
        } */

        public double ValorTotalEmEstoque() {
            return _preco * _quantidade; 
        }
        public void AdicionarProdutos(int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        } 

        public override string ToString() {
            return _nome + ", $ " + _preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + _quantidade
                + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture); }
    }
}