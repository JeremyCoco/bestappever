<template>
  <div id="app">
    <router-view/>
  </div>
</template>

<style lang="scss">
@import "./scss/custom-bootstrap.scss";
@import "../node_modules/bootstrap/scss/bootstrap.scss";
</style>

<style lang="scss">
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
#nav {
  padding: 30px;
  a {
    font-weight: bold;
    color: #2c3e50;
    &.router-link-exact-active {
      color: #42b983;
    }
  }
}

body{
  margin: 0px;
}

.screenContainer {
  height: 100vh;
  background: rgb(97,163,165);
  background: linear-gradient(140deg, rgba(97,163,165,1) 0%, rgba(70,54,93,1) 35%, rgba(108,53,92,1) 93%);
}

.smallDividerBlock{
  width: 100px;
  height: 10px;
  background: #70F4D8;
  margin: 10px auto;
}
</style>
