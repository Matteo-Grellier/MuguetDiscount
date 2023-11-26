# Utiliser une image de node pour construire l'application
FROM node:latest

# Définir le répertoire de travail dans le conteneur
WORKDIR /app

# Copier les fichiers package.json et package-lock.json
COPY package*.json /app

# Installer les dépendances
RUN npm install

# Copier le reste des fichiers de l'application
COPY . /app

# Construire l'application React
RUN npm run build

# Définir la commande pour exécuter l'application
CMD ["npm", "start"]