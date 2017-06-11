const express = require('express')
const app = express()

app.get('/', function (req, res) {
	res.redirect("/hello");
});

app.get('/hello', function (req, res) {
	res.send('Hello World!')
});

/*
app.get('/hello/:name?', function (req, res) {
	var name = req.params.name || "World";
	res.send(`Hello ${name}!`);
});
*/

app.listen(3000, function () {
	console.log('Example app listening on port 3000!')
});

module.exports = app
