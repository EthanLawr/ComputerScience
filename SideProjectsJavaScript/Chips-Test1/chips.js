const Discord = require("discord.js");

const client = new Discord.Client();
global._ = require("lodash");
const fs = require('fs');
global.chalk = require("chalk");
global.Messager = new (require("events"));
global.Command = require("./Command");
global.CommandHandler = require("./CommandHandler")(Discord, client);
const readline = require('readline');

Messager.on("eval", ({ evalContent, vars, timestamp }) => {
  const { msg, message, channel, guild, send, reply, content, noprefix, prefix, c, author, member } = vars;
  try {
    Messager.emit("dideval" + timestamp, {
      result: eval(evalContent),
      err: false
    });
  } catch(err) {
    Messager.emit("dideval" + timestamp, {
      result: err,
      err: true
    });
  }
});

client.commands = {};
fs.readdirSync("./commands").map(f => {
  if (/\.js/.test(f)) {
    const precmd = require(`./commands/${f}`);
    client.commands[precmd.name] = new Command(precmd);
  }
});

const prefix = "-";

client.on("ready", _ => {
  console.log('Im ready!');
  client.user.setStatus("online");
  client.user.setActivity("Do -help");
});

const stdin = process.openStdin();
client.on("debug", console.log);
let d = "";

const pastes = [
  ["/shrug", "¯\\_(ツ)_/¯"],
  ["/tableflip", "(╯°□°）╯︵ ┻━┻"],
  ["/unflip", "┬─┬﻿ ノ( ゜-゜ノ)"],
  [":Thoughts:", "<:Thoughts:278104583501381632>"]
];

global.rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

const send = (message, c) => {
  c.sendMessage(message);
};

const detectPastes = txt => {
  for (const i in pastes) {
    if (txt == pastes[i][0]) {
      console.log("paste " + i + " found!");
      return pastes[i][1];
    }
  }
  return txt;
};

client.on("message", message => {
  if (message.author.bot) return;


  if (!message.content.toLowerCase().startsWith(prefix.toLowerCase())) return;
  const c = message.channel;
  CommandHandler(message, prefix);
});
client.login('Mzc3MjYyNjI0MTkyMjAwNzA1.Dabjow.FmyLAtUrMP_QSEcHzA9WspCyYD8');
