import Vue from "vue";
import Router from "vue-router";
import SplashScreen from "./views/SplashScreen";
import FindTeam from "./views/team/FindTeam";
import CreateTeam from "./views/team/CreateTeam";
import RegisterTeam from "./views/team/RegisterTeam";
import Login from "./views/Login";
import Dashboard from "./views/Dashboard";
import MemberTypes from "./views/team/MemberTypes";
import Tasks from "./views/team/Tasks";
import Members from "./views/team/Members";
import Statistics from "./views/team/Statistics";
import TaskDetails from "./views/team/TaskDetails";
import MemberDetails from "./views/team/MemberDetails";

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
    {
      path: "/team/memberTypes",
      name: "MemberTypes",
      component: MemberTypes
    },
    {
      path: "/team/members",
      name: "Members",
      component: Members
    },
    {
      path: "/team/tasks",
      name: "Tasks",
      component: Tasks
    },
    {
      path: "/team/statistics",
      name: "Statistics",
      component: Statistics
    },
    {
      path: "/team/taskDetails",
      name: "TaskDetails",
      component: TaskDetails
    },
    {
      path: "/team/memberDetails",
      name: "MemberDetails",
      component: MemberDetails
    },
  ]
});
