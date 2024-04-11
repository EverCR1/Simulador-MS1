# Proyecto Modelación y Simulación 1
**Integrantes**
Ever Corazón 202042236
Olsend Luna 202040897
Carlos Meza 201845029

*Antes de subir cambios verificar la rama donde estamos situados*

## Comandos
### Consultar estado 
```
git status
```
### Obtener cambios del repositorio
```
git pull
```
### Subir cambios
```
git add -A
git commit -m "Comentario"
git push
```
### Cambiar de rama
```
git checkout nombreRama
```
### Crear nueva rama
```
git checkout ramaBase
git pull
git checkout -b ramaNueva
git push --set-upstream origin ramaNueva
```
### Fusionar ramas
```
git checkout ramaBase
git pull
git checkout -b ramaFusionar
git pull
git merge ramaBase
```

*Si se generan conflictos durante el merge, resolverlos en el entorno local y volver a pushear*
