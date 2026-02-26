using System.Text.Json.Serialization;
public class Livros
{
    [JsonPropertyName("id")]
    public string Id{get; set; }

    [JsonPropertyName("titulo")]
    public string Titulo{get; set; }

    [JsonPropertyName("genero")]
    public string Genero{get; set;}

    [JsonPropertyName("preco")]
    public decimal Preco{get; set;}

    [JsonPropertyName("numeropaginas")]
    public int Numeropaginas{get; set; }

    [JsonPropertyName("quantidade")]
    public int Quantidade {get; set ;}

}

public class Veiculos
{
     [JsonPropertyName("id")]
    public string Id{get; set; }

    [JsonPropertyName("modelo")]
    public string Modelo{get; set; }

    [JsonPropertyName("marca")]
    public string Marca{get; set;}

    [JsonPropertyName("ano")]
    public decimal Ano{get; set;}

    [JsonPropertyName("preco")]
    public decimal Preco{get; set; }


}

public class Ferramentas
{
     [JsonPropertyName("id")]
    public string Id{get; set; }

    [JsonPropertyName("nome")]
    public string Nome{get; set; }

    [JsonPropertyName("quantidade")]
    public string Quantidade{get; set;}

    [JsonPropertyName("categoria")]
    public decimal Categoria{get; set;}

    [JsonPropertyName("fornecedor")]
    public decimal Fornecedor ginas{get; set; }


}


public class Universidade
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("cidade")]
    public string Cidade { get; set; }

    [JsonPropertyName("pais")]
    public string Pais { get; set; }

    [JsonPropertyName("ano_fundacao")]
    public int AnoFundacao { get; set; }

    [JsonPropertyName("numero_de_alunos")]
    public int NumeroDeAlunos { get; set; }

    [JsonPropertyName("cursos_principais")]
    public List<string> CursosPrincipais { get; set; }
}


public class Shopping
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("nome")]
    public string Nome { get; set; }

    [JsonPropertyName("cidade")]
    public string Cidade { get; set; }

    [JsonPropertyName("pais")]
    public string Pais { get; set; }

    [JsonPropertyName("ano_inauguracao")]
    public int AnoInauguracao { get; set; }

    [JsonPropertyName("numero_de_lojas")]
    public int NumeroDeLojas { get; set; }

    [JsonPropertyName("principais_atracoes")]
    public List<string> PrincipaisAtracoes { get; set; }
}
