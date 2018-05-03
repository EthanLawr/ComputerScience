global.Discord = require('discord.js');
global.Logger = require('./functions/logger');
global.config = require('./config');
const client = new global.Discord.Client({
  fetchAllMembers: true,
  messageCacheMaxSize: 100,
});

const fs = require('fs');
function LLoad(type) {
  if (type === 'commands') {
    return fs.readdir(`./${type}/`, (error, files) => {
      let startOne = Date.now();
      if (error) {
        throw new Error(error);
      }
      client.commands = [];

      files.map(file => {
        client.commands[file.replace(/\..*/, '')] = require(`./${type}/${file}`);

        if (files.indexOf(file) === files.length - 1) {
          global.Logger.start(`Loaded ${files.length} ${type}! (${Date.now() - startOne} ms)`);
        }
        return true;
      });
    });
  } else {
    return fs.readdir(`./${type}/`, (error, files) => {
      let startTwo = Date.now();
      if (error) {
        throw new Error(error);
      }

      files.map(file => {
        let typeRunner = require(`./${type}/${file}`);
        let typeName = file.split('.')[0];
        client.on(typeName, (...args) => typeRunner(client, ...args));
        if (files.indexOf(file) === files.length - 1) {
          global.Logger.start(`Loaded ${files.length} ${type}! (${Date.now() - startTwo} ms)`);
        }
        return true;
      });
    });
  }
}
// Commands
LLoad('commands');
LLoad('commands');
LLoad('commands');
LLoad('commands');
LLoad('commands');
// Events
LLoad('events');
// Functions
LLoad('functions');

process.on('unhandledRejection', err => {
  global.Logger.error('[FATAL] Unhandled Promise Rejection.', err);
  process.exit(1);
});
process.on('uncaughtException', err => {
  let errmsg = (err ? err.stack || err : '').toString().replace(new RegExp(`${__dirname}/`, 'g'), './');
  global.Logger.error(errmsg);
});
client.login(global.config.discord.token);
client.config = global.config;

global.Mordant = new global.Discord.Client();
global.Mordant.on('ready', () => {
  global.Logger.log('Weeb helper is ready!');
  global.Mordant.user.setStatus('idle');
  global.Mordant.user.setActivity('Helping Senpai');
  global.Mordant.config = global.config;
});
global.Mordant.on('error', e => global.Logger.error(e));
global.Mordant.on('warn', e => global.Logger.log(e));
global.Mordant.on('debug', e => global.Logger.log(e));
global.Mordant.on('disconnect', event => {
  setTimeout(() => client.destroy().then(() => global.Mordant.login(global.config.discord.token)), 10000);
  global.Logger.log(`[DISCONNECT] Notice: Disconnected from gateway with code ${event.code} - Attempting reconnect.`);
});
global.Mordant.login(global.config.discord.token2);
