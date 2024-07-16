let jsonData;

jsonData = await fetch('http://localhost:59436/data/site-data.json')
                .then((response) => response.json());

console.log(jsonData);

let ulElement = document.getElementsByTagName("ul")[0];

for (let key in jsonData) {
    var node = document.createElement("li");
    var content = document.createTextNode(key);
    node.appendChild(content);
    ulElement.appendChild(node);
}