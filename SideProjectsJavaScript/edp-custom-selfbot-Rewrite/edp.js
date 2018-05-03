const Discord = require('discord.js');
const client = new Discord.Client();

const fs = require('fs');

const config = require('./config');

const Logger = require('./functions/logger');

let start = Date.now();

fs.readdir('./commands/', (error, files) => {

	if(error) {
		throw new Error(error);
	}
	client.commands = [];

	files.map((file) => {

	client.commands[file.replace(/\..*/, '')] = require('./commands/' + file);

	if (files.indexOf(file) === files.length - 1) {

	Logger.start('Loaded ' + files.length + ' commands! (' + (Date.now() - start) + ' ms)');

	fs.readdir('./events/', (error, files) => {

		if(error) {
			throw new Error(error);
		}

	files.map((file) => {
		let eventRunner = require('./events/' + file);
		let eventName = file.split('.')[0];
		client.on(eventName, (...args) => eventRunner(client, ...args));
		if (files.indexOf(file) === files.length - 1) {
			Logger.start('Loaded ' + files.length + ' events! (' + (Date.now() - start) + ' ms)');
			client.login(config.discord.token);
			client.config = config;
		}
	});});

	fs.readdir('./functions/', (error, files) => {

		if(error) {
			throw new Error(error);
		}

	files.map((file) => {
		let functionRunner = require('./functions/' + file);
		let functionName = file.split('.')[0];
		client.on(functionName, (...args) => functionRunner(client, ...args));
		if (files.indexOf(file) === files.length - 1) {
			Logger.start('Loaded ' + files.length + ' functions! (' + (Date.now() - start) + ' ms)');
		}
	});});}});
});
	
