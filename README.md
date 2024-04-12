# Proyecto Modelación y Simulación 1

**Integrantes**

Ever Corazón 202042236

Olsend Luna 202040897

Carlos Meza 201845029

*Antes de subir cambios verificar la rama donde estamos situados*

## Pasos a seguir

1. Si ya existe una rama, utilizar git checkout para trabajar en ella

2. Si no existe una rama, crearla y asegurarse de trabajar en ella antes de codificar

3. Antes de subir cambios al repositorio utilizar git status para saber la rama donde estamos

4. Subir cambios a la rama

*Extras*

6. Si se quiere obtener los cambios de otra rama para probar las funcionalidades completas, utilizar la parte de Fusionar Ramas

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
