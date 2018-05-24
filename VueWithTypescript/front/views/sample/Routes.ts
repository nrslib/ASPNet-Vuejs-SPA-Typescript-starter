import RootComponent from "./components/Root.vue";
import IndexComponent from "./components/index/Index.vue";
import NextComponent from "./components/next/Next.vue";

export default {
    path: "/sample",
    component: RootComponent,
    children: [
        {
            path: "",
            name: "index",
            component: IndexComponent
        },
        {
            path: "next",
            name: "next",
            component: NextComponent
        }
    ]
}