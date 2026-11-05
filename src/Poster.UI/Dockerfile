FROM node:26-alpine
WORKDIR /src
COPY src/Poster.UI/package.json src/Poster.UI/package-lock.json ./
RUN npm ci --no-audit
COPY src/Poster.UI .
EXPOSE 4200
CMD ["npm", "run", "start", "--", "--host", "0.0.0.0", "--poll", "2000"]

FROM node:26-alpine AS build
WORKDIR /app
COPY src/Poster.UI/package.json src/Poster.UI/package-lock.json ./
RUN npm ci --no-audit
COPY src/Poster.UI .
RUN npx ng build --configuration production

FROM nginx:alpine
COPY --from=build /app/dist/Poster.UI/browser /usr/share/nginx/html
EXPOSE 80
CMD ["nginx", "-g", "daemon off;"]
