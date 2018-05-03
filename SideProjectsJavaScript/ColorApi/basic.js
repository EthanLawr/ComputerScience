const { get } = require('snekfetch'); //This is the node module we will be using to contact the API.

console.log( "** ** ** ** ** ** ** ** ** Colors ** ** ** ** ** ** ** ** ** **");
async function idProcess(color) {
	try {
		let id = await get(`http://www.colourlovers.com/api/color/${color}&format=json`).then(r => r.body[0].id).then(r => console.log(r));
		return id;
	} catch(err) {
		console.error(err); return undefined;
	}
}
//function id(color){
//	return idProcess(color).then(r => console.log(r));
//}
async function title(color) {
	try {
		let title = await get(`http://www.colourlovers.com/api/color/${color}&format=json`).then(r => r.body[0].title).then(r => console.log(r));
		return title;
	} catch(err) {
		console.error(err); return undefined;
	}
}

id('345345');
title('345345');
get(`http://www.colourlovers.com/api/color/345345&format=json`).then(r => { //This gets a response from the JSON API
console.log(r.body[0].userName);
console.log(r.body[0].numViews);
console.log(r.body[0].numVotes);
console.log(r.body[0].numComments);
console.log(r.body[0].numHearts);
console.log(r.body[0].rank);
console.log(r.body[0].dateCreated);
console.log();
console.log(r.body[0].hex);
console.log();
console.log(r.body[0].rgb);
console.log(r.body[0].rgb.red);
console.log(r.body[0].rgb.green);
console.log(r.body[0].rgb.blue);
console.log();
console.log(r.body[0].hsv);
console.log(r.body[0].hsv.hue);
console.log(r.body[0].hsv.saturation);
console.log(r.body[0].hsv.value);
console.log(r.body[0].hsv.value);
console.log();
console.log(r.body[0].url);
console.log(r.body[0].imageUrl);
console.log(r.body[0].badgeUrl);
console.log(r.body[0].apiUrl);
console.log();
console.log( "> That's it. You can now open the URLs above in a browser");
console.log( "> and check out the generated images.");
});