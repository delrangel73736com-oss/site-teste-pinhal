# Balneário Pinhal — Dossiê da cidade

Mostruário web sobre o município de Balneário Pinhal (RS) e o seu distrito de
Magistério: história, números, pontos turísticos, distritos e curiosidades.

## Como rodar

Pré-requisito: [.NET SDK 8.0](https://dotnet.microsoft.com/download) instalado.

```bash
cd BalnearioPinhalShowcase
dotnet run
```

O console vai mostrar algo como `Now listening on: http://localhost:5000`.
Abra esse endereço no navegador — a página inicial (`wwwroot/index.html`) é
servida automaticamente e busca os dados nos endpoints da API abaixo.

## Como o programa é organizado

- **`Program.cs`** — host mínimo do ASP.NET Core. Serve os arquivos estáticos
  de `wwwroot/` (HTML/CSS/JS) e expõe uma API somente-leitura em `/api/*`.
- **`Dados/AcervoCidade.cs`** — o "banco de dados" em C#: records tipados
  (`FichaTecnica`, `Numero`, `PontoTuristico`, `Curiosidade`, `Distrito`) com
  as informações reais sobre a cidade, reunidas a partir de fontes públicas
  (IBGE, site da prefeitura e imprensa regional do Litoral Norte gaúcho).
- **`wwwroot/index.html` + `css/styles.css` + `js/app.js`** — o front-end.
  O `app.js` faz `fetch` nos endpoints abaixo e monta cada seção da página
  dinamicamente — ou seja, a página em si não tem dados "chumbados": tudo
  vem do back-end em C#.

### Endpoints da API

| Rota                      | Conteúdo                                   |
|---------------------------|---------------------------------------------|
| `GET /api/ficha`          | Ficha técnica do município (coordenadas, fundação, prefeito...) |
| `GET /api/numeros`        | Indicadores (população, área, orla, etc.)  |
| `GET /api/pontos-turisticos` | Lista de pontos turísticos                |
| `GET /api/distritos`      | Os três distritos do município             |
| `GET /api/curiosidades`   | Curiosidades e histórico da cidade          |

Para adicionar ou corrigir um dado, basta editar as listas em
`Dados/AcervoCidade.cs` — o front-end atualiza sozinho, sem precisar mexer
no HTML.

## Sobre o design

Você pediu o site "futurist.com" (Futurist.com, o site/blog de futurismo e
tendências de Glen Hiemstra) como referência máxima. Não copiei o layout
dele diretamente — reproduzir o design de outro site levantaria questão de
direitos autorais, e a página é essencialmente um blog de artigos, sem um
sistema visual fixo para "clonar". Em vez disso, usei o espírito do site
(editorial, tipo revista de tendências, confiante, com bastante texto bem
tipografado) como inspiração e criei uma identidade própria para Balneário
Pinhal: um "dossiê" com tipografia serifada (Fraunces) para títulos, texto
em Inter, paleta baseada na identidade local — verde-pinheiral escuro,
areia, mel e um teal de água — em vez do azul-turquesa clichê de folder de
praia.

Se você quiser, posso ajustar cores, seções ou trazer fotos reais da cidade
depois.
