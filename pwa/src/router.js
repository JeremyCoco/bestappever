import Vue from "vue";
import Router from "vue-router";
import SplashScreen from "./views/SplashScreen";
import FindTeam from "./views/FindTeam";
import CreateTeam from "./views/CreateTeam";
import RegisterTeam from "./views/RegisterTeam";
import Login from "./views/Login";
import Dashboard from "./views/Dashboard";

Vue.use(Router);

export default new Router({
  routes: [
    {
      path: "/",
      name: "splash",
      component: SplashScreen
    },
    {
      path: "/team-find",
      name: "FindTeam",
      component: FindTeam
    },
    {
      path: "/team-create",
      name: "CreateTeam",
      component: CreateTeam
    },
    {
      path: "/register",
      name: "RegisterTeam",
      component: RegisterTeam
    },
    {
      path: "/login",
      name: "Login",
      component: Login
    },
    {
      path: "/dashboard",
      name: "Dashboard",
      component: Dashboard
    },
  ]
});
