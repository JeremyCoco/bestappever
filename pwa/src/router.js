import Vue from "vue";
import Router from "vue-router";

import Home from "./views/Home";

import AuthTeamFind from "./views/AuthTeamFind";
import AuthTeamCreate from "./views/AuthTeamCreate";
import AuthTeamRegister from "./views/AuthTeamRegister";
import AuthTeamLogin from "./views/AuthTeamLogin";

import TeamDashboard from "./views/TeamDashboard";

Vue.use(Router);

export default new Router({
  routes: [
    {
      path: "/",
      name: "Home",
      component: Home
    },
    {
      path: "/Auth/Team/Find",
      name: "AuthTeamFind",
      component: AuthTeamFind
    },
    {
      path: "/Auth/Team/Create",
      name: "AuthTeamCreate",
      component: AuthTeamCreate
    },
    {
      path: "/Auth/Team/:name/Register",
      name: "AuthTeamRegister",
      component: AuthTeamRegister,
      props: true
    },
    {
      path: "/Auth/Team/:name/Login",
      name: "AuthTeamLogin",
      component: AuthTeamLogin,
      props: true
    },
    {
      path: "/Team/Dashboard",
      name: "TeamDashboard",
      component: TeamDashboard
    }
  ]
});
