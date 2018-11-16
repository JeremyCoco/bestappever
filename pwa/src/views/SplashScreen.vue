<template>
  <div class="container screenContainer">
      <router-link to="/team-find" tag="button">Znajdź drużynę</router-link>
      <router-link to="/team-create" tag="button">Założ drużynę</router-link>
  </div>
</template>

<script>
// @ is an alias to /src

export default {
};
</script>

<style scoped>
.screenContainer {
	margin:0px;
	height: 100vh;
	background: red;
}
</style>
