namespace BalnearioPinhalShowcase.Dados;

// ---- Modelos -----------------------------------------------------------

public record FichaTecnica(
    string Nome,
    string Gentilico,
    string Estado,
    string Coordenadas,
    string FusoHorario,
    string Fundacao,
    string Prefeito
);

public record Numero(
    string Rotulo,
    string Valor,
    string Contexto
);

public record PontoTuristico(
    string Nome,
    string Categoria,
    string Distrito,
    string Descricao
);

public record Curiosidade(
    string Titulo,
    string Texto
);

public record Distrito(
    string Nome,
    string Criacao,
    string Descricao
);

// ---- Acervo (dados reais e verificáveis sobre o município) -------------

public static class AcervoCidade
{
    public static readonly FichaTecnica Ficha = new(
        Nome: "Balneário Pinhal",
        Gentilico: "balneário-pinhalense (ou pinhalense)",
        Estado: "Rio Grande do Sul — Litoral Norte",
        Coordenadas: "30°14'49\" S, 50°13'58\" O",
        FusoHorario: "UTC−3 (Horário de Brasília)",
        Fundacao: "Emancipado de Cidreira em 1995; instalado em 1º de janeiro de 1997",
        Prefeito: "Luiz Cezar Danelli Furini (gestão 2025)"
    );

    public static readonly List<Numero> Numeros = new()
    {
        new("População estimada", "15.413", "Estimativa IBGE para 2025; o censo de 2022 havia registrado 14.955 habitantes"),
        new("Área territorial", "102,4 km²", "Densidade demográfica de aproximadamente 146 hab/km²"),
        new("Orla marítima", "8 km", "Faixa contínua de praias e dunas preservadas"),
        new("Distritos", "3", "Sede, Magistério e Túnel Verde"),
        new("Idade como município", "≈ 29 anos", "Instalado em 1997, desmembrado de Cidreira"),
        new("PIB per capita", "R$ 22.276", "Referência 2023, segundo o IBGE"),
    };

    public static readonly List<PontoTuristico> PontosTuristicos = new()
    {
        new(
            "Túnel Verde",
            "Cartão-postal",
            "Túnel Verde",
            "Corredor formado por eucaliptos plantados em 1937 por Francisco Segura Garcia. Tinha 2.800 m originais e hoje se estende por cerca de 3.500 m — um dos símbolos mais fotografados do município."
        ),
        new(
            "Praia de Magistério",
            "Praia",
            "Magistério",
            "Deve o nome a uma antiga colônia de férias voltada a professores da rede estadual; mais tarde os lotes da região foram oferecidos a docentes, e o nome permaneceu."
        ),
        new(
            "Lagoa da Rondinha",
            "Natureza",
            "Sede",
            "Espelho d'água tranquilo ligado a uma das fazendas mais antigas da região, com paisagem valorizada para caminhadas e contemplação do pôr do sol."
        ),
        new(
            "Largo Osso da Baleia",
            "Área urbana",
            "Sede",
            "Point à beira-mar com um dos nomes mais curiosos do litoral gaúcho, ponto de encontro e um dos locais mais avaliados por visitantes."
        ),
        new(
            "Parque do Cidadão",
            "Lazer",
            "Sede",
            "Área verde urbana usada para caminhada, esporte e convivência, próxima ao centro administrativo da cidade."
        ),
        new(
            "Monumentos da Melinha",
            "Arte urbana",
            "Vários",
            "Dezoito esculturas temáticas da abelha Melinha espalhadas por praças, rotatórias e entradas de praia — um roteiro fotográfico não oficial da cidade."
        ),
        new(
            "Skate Park de Balneário Pinhal",
            "Esporte",
            "Sede",
            "Pista pública voltada ao skate e esportes de rolamento, um dos pontos de encontro da juventude local."
        ),
        new(
            "Lago Verde",
            "Natureza",
            "Túnel Verde",
            "Espaço com churrasqueiras e sombra no distrito do Túnel Verde, com uma estátua de Santa Rita de Cássia às margens do lago."
        ),
    };

    public static readonly List<Curiosidade> Curiosidades = new()
    {
        new(
            "A \"Capital Estadual do Mel\"",
            "Balneário Pinhal carrega esse título pela força da apicultura local: o mel movimenta renda, turismo e até a identidade visual da cidade, presente em monumentos e eventos."
        ),
        new(
            "Melinha e Meladinho",
            "Os mascotes oficiais — uma abelha e um urso apaixonado por mel — nasceram para explicar a relação entre apicultura, sustentabilidade e o espírito receptivo da população pinhalense."
        ),
        new(
            "O nome vem dos pinheirais",
            "\"Pinhal\" faz referência a uma extensão de pínus plantada na antiga Fazenda do Pinhal, terra que passou por diferentes donos desde o século XIX até dar origem ao município."
        ),
        new(
            "Uma história que começa em 1767",
            "A sesmaria da Cidreira, que originou a região, foi doada pela Coroa portuguesa ainda no século XVIII — muito antes de o território virar balneário e, só em 1995, município independente."
        ),
        new(
            "Vizinha de dunas e lagoas",
            "O roteiro de dunas e lagoas é compartilhado com o município vizinho, Cidreira, formando uma paisagem contínua de areia, água doce e vegetação de restinga."
        ),
        new(
            "Magistério tem nome de professor",
            "Poucas praias no Brasil carregam uma homenagem tão direta à categoria docente quanto Magistério, batizada por ter sido colônia de férias do magistério estadual."
        ),
    };

    public static readonly List<Distrito> Distritos = new()
    {
        new(
            "Sede (Balneário Pinhal)",
            "Distrito-sede desde a emancipação, em 1997",
            "Concentra a administração municipal, o comércio e praias como Pinhal Zona Sul e Zona Nobre, além de pontos como a Lagoa da Rondinha e o Largo Osso da Baleia."
        ),
        new(
            "Magistério",
            "Criado em 1998 pela lei municipal nº 179",
            "Bairro-praia nascido de uma colônia de férias para professores estaduais, hoje uma das praias mais bem avaliadas do município."
        ),
        new(
            "Túnel Verde",
            "Criado em 1998 pela lei municipal nº 179",
            "Batizado pelo famoso corredor de eucaliptos, reúne o Lago Verde e outras áreas de lazer entre vegetação preservada."
        ),
    };
}
