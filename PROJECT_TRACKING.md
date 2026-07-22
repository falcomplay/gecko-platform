# Gecko Platform — Project Tracking

Ce document conserve les décisions importantes sans remplacer le backlog ni le README.

## Objectif actuel

Construire une tranche fonctionnelle simple et démontrable, puis l'utiliser pour progresser sur :

- .NET et Clean Architecture ;
- modélisation du domaine et tests ;
- MongoDB et API REST ;
- Docker et GitLab CI/CD ;
- Kubernetes, Helm, OpenShift et DevSecOps.

Le projet reste un support d'apprentissage et de démonstration. Les abstractions sans besoin concret sont évitées.

## État

### Terminé

- US-001 — Repository Initialization
- US-002 — Project Architecture
- US-003 — Backend Design
- US-004 — Backend Foundation

### En cours

- EPIC 1 — Foundation
- US-005 — Domain Foundation

## User Story en cours

> En tant qu'utilisateur authentifié, je veux enregistrer un dépôt Git comme projet afin de pouvoir ensuite configurer et suivre son cycle de livraison.

## Décisions métier — Project V1

- Un projet représente la configuration de livraison d'un dépôt Git.
- Un projet appartient à un créateur, sans dépendre directement d'une entité `User`.
- Le nom est obligatoire, modifiable et unique par créateur.
- La comparaison des noms est insensible à la casse.
- La description est facultative.
- Le dépôt Git est obligatoire et référencé par une URL HTTPS.
- Tous les fournisseurs Git sont acceptés.
- Un même créateur ne peut pas enregistrer deux fois le même dépôt.
- Deux créateurs différents peuvent utiliser le même nom ou enregistrer le même dépôt.
- La date de création est conservée.

## Hors périmètre V1

- archivage pendant 30 jours et suppression définitive ;
- gestion détaillée des utilisateurs et des équipes ;
- prise en charge particulière des monorepos ;
- plusieurs configurations de livraison pour un même dépôt ;
- versions, technologies et autres métadonnées anticipées.

Ces sujets seront réévalués lorsqu'une User Story les rendra nécessaires.

## Prochaines étapes

1. Définir le modèle minimal de `Project`.
2. Écrire les premiers tests unitaires du domaine.
3. Exposer un premier cas d'usage applicatif.
4. Persister les projets avec MongoDB.
5. Exposer une API REST minimale.
6. Conteneuriser l'application.
7. Créer un pipeline GitLab de build et de tests.
8. Ajouter progressivement sécurité, qualité et déploiement.

## Principes de travail

- Comprendre le besoin avant d'écrire du code.
- Avancer par petites tranches fonctionnelles.
- Appliquer YAGNI : ne pas développer un besoin hypothétique.
- Utiliser CQRS, Repository Pattern et les abstractions uniquement lorsqu'ils apportent une valeur concrète.
- Conserver le domaine indépendant des frameworks et de l'infrastructure.
