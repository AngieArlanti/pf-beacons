import React from 'react';
import { StyleSheet, Text, View, Button, NativeModules } from 'react-native';
const ToastExample = NativeModules.ToastExample;

export default class App extends React.Component {
  showToast (){
    ToastExample.show('Awesome', ToastExample.SHORT);
  }

  render() {
    return (
      <View style={styles.container}>
        <Button title= "Show Toast!" onPress={this.showToast}/>
      </View>
    );
  }
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    backgroundColor: '#fff',
    alignItems: 'center',
    justifyContent: 'center',
  },
});