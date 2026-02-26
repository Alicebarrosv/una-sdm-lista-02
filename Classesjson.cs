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

public class veiculos
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

public class ferramentas
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

