import Vue from 'vue';
import { Component } from 'vue-property-decorator';
import Menu from '../navmenu/navmenu.vue';


@Component({
    components: {
        MenuComponent: Menu
    }
})
export default class AppComponent extends Vue {
}
