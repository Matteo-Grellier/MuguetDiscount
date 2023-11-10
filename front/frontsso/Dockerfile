# Utilisation d'une image de base avec Node.js
FROM node:latest

# Créez un répertoire de travail
WORKDIR /usr/src/app

# Copiez les fichiers nécessaires (package.json, package-lock.json) dans le conteneur
COPY package*.json ./

# Installez les dépendances
RUN npm install

# Copiez le reste des fichiers de l'application
COPY . .

# Construisez l'application
RUN npm run build

# Commande pour démarrer l'application
CMD ["npm", "start"]
