using System;

class Cliente extends Pedido {
  private int id;
  private string cpf;
  private string nome;
  private DateTime criadoEm;

  public Cliente(int id, string cpf, string nome, DateTime criadoEm) {
    this.id = id;
    this.cpf = cpf;
    this.nome = nome;
    this.criadoEm = criadoEm;
  }

  public override string ToString() {
    return "Cliente:" + nome + "| CPF: " + cpf + "| Identificação: " + id + "| Criado em: " + criadoEm.ToString("dd-mm-yyyy");
  }
}
