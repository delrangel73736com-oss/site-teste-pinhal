// Busca os dados servidos pelo back-end em C# (Program.cs) e monta cada
// seção do mostruário. Cada endpoint corresponde a um recorte do acervo
// da cidade definido em Dados/AcervoCidade.cs.

async function buscar(caminho) {
  const resposta = await fetch(caminho);
  if (!resposta.ok) {
    throw new Error(`Falha ao buscar ${caminho}: ${resposta.status}`);
  }
  return resposta.json();
}

function el(tag, className, html) {
  const node = document.createElement(tag);
  if (className) node.className = className;
  if (html !== undefined) node.innerHTML = html;
  return node;
}

async function montarFichaTecnica() {
  const alvo = document.getElementById("ficha-tecnica");
  try {
    const f = await buscar("/api/ficha");
    const dl = el("dl");
    const linhas = [
      ["Estado", f.estado],
      ["Coordenadas", f.coordenadas],
      ["Fuso horário", f.fusoHorario],
      ["Fundação", f.fundacao],
      ["Prefeito", f.prefeito],
      ["Gentílico", f.gentilico],
    ];
    for (const [rotulo, valor] of linhas) {
      dl.appendChild(el("dt", null, rotulo));
      dl.appendChild(el("dd", null, valor));
    }
    alvo.querySelector(".loading")?.remove();
    alvo.appendChild(dl);
  } catch (erro) {
    alvo.querySelector(".loading").textContent = "Não foi possível carregar a ficha técnica.";
    console.error(erro);
  }
}

async function montarNumeros() {
  const lista = document.getElementById("lista-numeros");
  try {
    const numeros = await buscar("/api/numeros");
    lista.innerHTML = "";
    for (const n of numeros) {
      const item = el("li");
      item.appendChild(el("span", "rotulo", n.rotulo));
      item.appendChild(el("span", "valor", n.valor));
      item.appendChild(el("span", "contexto", n.contexto));
      lista.appendChild(item);
    }
  } catch (erro) {
    lista.innerHTML = '<li><span class="rotulo">Não foi possível carregar os números.</span></li>';
    console.error(erro);
  }
}

async function montarPontosTuristicos() {
  const lista = document.getElementById("lista-pontos");
  try {
    const pontos = await buscar("/api/pontos-turisticos");
    lista.innerHTML = "";
    for (const p of pontos) {
      const item = el("li");

      const tag = el("div", "poi-tag", p.categoria);
      tag.appendChild(el("span", "distrito", p.distrito));

      const body = el("div", "poi-body");
      body.appendChild(el("h3", null, p.nome));
      body.appendChild(el("p", null, p.descricao));

      item.appendChild(tag);
      item.appendChild(body);
      lista.appendChild(item);
    }
  } catch (erro) {
    lista.innerHTML = '<li><p>Não foi possível carregar os pontos turísticos.</p></li>';
    console.error(erro);
  }
}

async function montarDistritos() {
  const alvo = document.getElementById("lista-distritos");
  try {
    const distritos = await buscar("/api/distritos");
    alvo.innerHTML = "";
    for (const d of distritos) {
      const bloco = el("article", "district");
      bloco.appendChild(el("h3", null, d.nome));
      bloco.appendChild(el("span", "criacao", d.criacao));
      bloco.appendChild(el("p", null, d.descricao));
      alvo.appendChild(bloco);
    }
  } catch (erro) {
    alvo.innerHTML = "<p>Não foi possível carregar os distritos.</p>";
    console.error(erro);
  }
}

async function montarCuriosidades() {
  const alvo = document.getElementById("lista-curiosidades");
  try {
    const curiosidades = await buscar("/api/curiosidades");
    alvo.innerHTML = "";
    for (const c of curiosidades) {
      const entrada = el("div", "entry");
      entrada.appendChild(el("h3", null, c.titulo));
      entrada.appendChild(el("p", null, c.texto));
      alvo.appendChild(entrada);
    }
  } catch (erro) {
    alvo.innerHTML = "<p>Não foi possível carregar as curiosidades.</p>";
    console.error(erro);
  }
}

document.addEventListener("DOMContentLoaded", () => {
  montarFichaTecnica();
  montarNumeros();
  montarPontosTuristicos();
  montarDistritos();
  montarCuriosidades();
});
