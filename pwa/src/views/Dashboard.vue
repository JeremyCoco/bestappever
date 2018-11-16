<template>
    <div class="container">
        <router-link to="/team/memberTypes" tag="button">Typy osób w zespole</router-link>
        <router-link to="/team/members" tag="button">Lista osób w zespole</router-link>
        <router-link to="/team/tasks" tag="button">Zadania</router-link>
        <router-link to="/team/statistics" tag="button">Statystyki</router-link>
    </div>
</template>

<script>
export default {
  name: "Dashboard"
};
</script>

<style scoped>
</style>
