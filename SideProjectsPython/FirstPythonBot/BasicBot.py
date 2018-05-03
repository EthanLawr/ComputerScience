import discord, asyncio, json, platform,datetime,time,os,sys
from discord.ext.commands import Bot
from discord.ext import commands

# Configuration
data = json.load(open('config.json'))

botclienttoken = data['discordbot']['token']
client = Bot(command_prefix="m!")
def prRed(prt): print("\033[91m {}\033[00m" .format(prt))
def prGreen(prt): print("\033[92m {}\033[00m" .format(prt))
def prYellow(prt): print("\033[93m {}\033[00m" .format(prt))
def prLightPurple(prt): print("\033[94m {}\033[00m" .format(prt))
def prPurple(prt): print("\033[95m {}\033[00m" .format(prt))
def prCyan(prt): print("\033[96m {}\033[00m" .format(prt))
def prLightGray(prt): print("\033[97m {}\033[00m" .format(prt))
def prBlack(prt): print("\033[98m {}\033[00m" .format(prt))
prGreen("Hello world")
@client.event
async def on_ready():
	print('Logged in as '+client.user.name+' (ID:'+client.user.id+') | Connected to '+str(len(client.servers))+' servers | Connected to '+str(len(set(client.get_all_members())))+' users')
	print('--------')
	print('Current Discord.py Version: {} | Current Python Version: {}'.format(discord.__version__, platform.python_version()))
	print('--------')
	print('Use this link to invite {}:'.format(client.user.name))
	print('https://discordapp.com/oauth2/authorize?client_id={}&scope=bot&permissions=8'.format(client.user.id))
	print('You are running Mordant (Python) v0.1') 
	print('Created by Diana Solace#0006')
	await client.change_presence(game=discord.Game(name='rawr')) #This is buggy, let us know if it doesn't work.
	return
	
@client.event
async def on_message(message):
	CRED = '\033[91m'
	CEND = '\033[0m'
	print(CRED + "Error, does not compute!" + CEND)
	print ("\x1B[31;40m" + 'Message from {0.author}: {0.content}'.format(message) + "\x1B0m")
# This is a basic example of a call and response command. You tell it do "this" and it does it.
@client.command()
async def ping(*args):

	await client.say('No u')

@client.command()
async def abuse(*args):

	return await client.say('Abooooosed!')

@client.command()
async def pikapalm(*args):
	await client.say('<:pikapalm:386946070271229952>')
	
@client.command()
async def hug(intensity : int=1):
	"""Because everyone likes hugs
	Up to 10 intensity levels."""
	name = " *" + discord.Member.name + "*"
	if intensity <= 0:
		msg = "(っ˘̩╭╮˘̩)っ" + name
	elif intensity <= 3:
		msg = "(っ´▽｀)っ" + name
	elif intensity <= 6:
		msg = "╰(*´︶`*)╯" + name
	elif intensity <= 9:
		msg = "(つ≧▽≦)つ" + name
	elif intensity >= 10:
		msg = "(づ￣ ³￣)づ" + name + " ⊂(´・ω・｀⊂)"
	return await client.send(msg)	

try:
    client.run(str(botclienttoken))
except discord.ClientException as e:
    logger.exception(e)


# Basic Bot was created by Habchy#1665
# Please join this Discord server if you need help: https://discord.gg/FNNNgqb
# Please modify the parts of the code where it asks you to. Example: The Prefix or The Bot Token
# This is by no means a full bot, it's more of a starter to show you what the python language can do in Discord.
# Thank you for using this and don't forget to star my repo on GitHub! [Repo Link: https://github.com/Habchy/BasicBot]

# The help command is currently set to be not be Direct Messaged.
# If you would like to change that, change "pm_help = False" to "pm_help = True" on line 9.